[<AutoOpen>]
module Eleven19.ActiveEtl.Collections
open System 

type PropertyGetter<'T,'P> = 'T -> 'P
type PropertySetter<'T,'P> = 'P -> 'T -> 'T

type Property<'T,'P> = PropertyGetter<'T,'P> * PropertySetter<'T,'P> 

let internal Property<'T,'P> getter setter : Property<'T,'P> = (getter,setter)


