﻿namespace FSharp.Data.DynamicSql

open System
open System.Data
open System.Data.SqlClient

// --------------------------------------------------------------------------------------
// Wrappers with dynamic operators for creating SQL Store Procedure calls

type DynamicDataReader(reader:IDataReader) =
  member private x.Reader = reader
  member x.Read() = reader.Read()
  static member (?) (dr:DynamicDataReader, name:string) : 'R = 
    unbox (dr.Reader.[name])
  interface IDisposable with
    member x.Dispose() = reader.Dispose()

type DynamicSqlCommand(cmd:SqlCommand) = 
  member private x.Command = cmd
  static member (?<-) (cmd:DynamicSqlCommand, name:string, value) = 
    cmd.Command.Parameters.Add(SqlParameter("@" + name, box value)) |> ignore
  member x.ExecuteNonQuery() = cmd.ExecuteNonQuery()
  member x.ExecuteReader() = new DynamicDataReader(cmd.ExecuteReader())
  member x.ExecuteScalar() = cmd.ExecuteScalar()
  member x.Parameters = cmd.Parameters
  interface IDisposable with
    member x.Dispose() = cmd.Dispose()

type DynamicSqlConnection(conn:SqlConnection) =
  member private x.Connection = conn
  static member (?) (conn:DynamicSqlConnection, name) = 
    let command = new SqlCommand(name, conn.Connection)
    command.CommandType <- CommandType.StoredProcedure
    new DynamicSqlCommand(command)
  member x.Open() = conn.Open()
  new (connStr:string) = new DynamicSqlConnection(connStr)
  interface IDisposable with
    member x.Dispose() = conn.Dispose()

type DynamicDataRow(dataRow:DataRow) =
  member private x.Row = dataRow
  static member (?) (dr:DynamicDataRow, name:string) : 'R = 
    unbox (dr.Row.[name])

[<AutoOpen>]
module DataRow =
  let (?) (row:DataRow) (columnName:string) = 
    unbox row.[columnName]
  let (?<-) (row:DataRow) (columnName:string) value  = 
    row.[columnName] <- value