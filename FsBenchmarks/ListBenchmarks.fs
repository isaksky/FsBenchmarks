module ListBenchmarks
open System
open BenchmarkDotNet.Attributes
open Imms
open Imms.FSharp

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
    let mutable b = System.Collections.Immutable.ImmutableList.Empty
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

//  [<Benchmark>]
//  member this.ImmListCE() =
//    immList {
//      for i = 0 to this.Size do
//        yield (i + i)
//    }
