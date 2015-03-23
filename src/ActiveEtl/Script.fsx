// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.
#load "DynamicSql.fs"
#load "DataReader.fs"
open System
open System.Data
open System.Linq
open Eleven19.ActiveEtl
open Eleven19.ActiveEtl.Data

//dataflow "DateDetailLoad" {
//  let src   = GetDataAsync()
//  let dest  = destination "ss"
//  src ==> dest
//}

let num = 5
printfn "%i" num
