module ListBenchmarks
open System
open BenchmarkDotNet.Attributes
open Imms
open Imms.FSharp
open Prime

type BuildListSeq() =
  [<Params (100, 1000, 10000)>] 
  member val public Size = 0 with get, set

  [<Benchmark(Baseline = true)>]
  member this.ResizeArray() =
    let a = ResizeArray<_>()
    for i = 0 to this.Size do
      a.Add(i + i)
    a

  [<Benchmark>]
  member this.SystemCollectionsImm() =
    let mutable a = System.Collections.Immutable.ImmutableList.Empty
    for i = 0 to this.Size do
      a <- a.Add(i + i)
    a

  [<Benchmark>]
  member this.FSharpListBuildAndRev() =
    let mutable a = []
    for i = 0 to this.Size do
      a <- (i + i)::a
    List.rev a

  [<Benchmark>]
  member this.ImmList() =
    let mutable a = ImmList.empty
    for i = 0 to this.Size do
      a <- ImmList.addLast (i + i) a
    a

  [<Benchmark>]
  member this.Ulist() =
    let mutable a = Ulist.makeEmpty(None)
    for i = 0 to this.Size do
      a <- Ulist.add (1 + 1) a
    a


type SwitchFirst2() =
  let mutable _fslist = []
  let mutable _immList = ImmList.empty

  [<Params (100)>] 
  member val public Size = 0 with get, set

  [<Setup>]
  member this.SetupData() =
    _fslist <- [for i = 0 to this.Size do yield i + i ]
    _immList <- immList { for i = 0 to this.Size do yield i + i }

  [<Benchmark>]
  member this.fsList() =
    let mutable a = _fslist
    for i = 0 to this.Size do
      a <-
        match a with
        | x1::x2::xs ->
          x2::x1::xs
        | _ -> failwith "Logic error"
    a

  [<Benchmark>]
  member this.ImmList() =
    let mutable a = _immList
    for i = 0 to this.Size do
      a <- 
        match a with
        | First2(x1, x2, xs) ->
          xs.AddFirst(x2).AddFirst(x1)
        | _ -> failwith "Logic error"
    a
