namespace Eleven19.ActiveEtl

module DataRecord =
  open System

  type DataRecordProperty<'T,'P> =
  | ReadOnly  of getter: PropertyGetter<'T,'P>
  | WriteOnly of setter:PropertySetter<'T,'P>
  | ReadWrite of getter: PropertyGetter<'T,'P> * setter:PropertySetter<'T,'P>

  let addReadOnlyProperty getter =
    ReadOnly getter

  let registerReadOnlyIndexedProperty (getter:PropertyGetter<'T,'P>) index indexed =
    ()
    

  let makeOrdinalRecord propertyMap data =
    ()

  let inline getAt index vector = (^a : (member get_Item  : int -> 'b) (vector, index));;
//  let inline getValue< ^a when ^a : (member get_Item  : int -> obj )> (idx:int) (item:^a) = 
//    item.[0]

  type MemoizedDataRecord (data:obj array) =
    new (fValues) =
      MemoizedDataRecord(fValues())

    member this.GetValues() = data
    member this.GetValue index = data.[index]

    static member inline Create (record:^a) =()


//  type IndexedObjectReadRecord< ^a when ^a: (member get_Item: int -> obj)> (indexedObj:^a) =
//    member inline this.GetValue index = indexedObj.[index] 
//
//    member inline this.Item
//      with get(index:int) = indexedObj.[index]
