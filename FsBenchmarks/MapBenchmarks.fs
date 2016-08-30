module MapBenchmarks
open System
open BenchmarkDotNet.Attributes
open Imms
open Imms.FSharp
open Prime

type BuildMapSeq() =
  [<Params (100, 1000, 10000)>] 
  member val public Size = 0 with get, set

  [<Benchmark(Baseline = true)>]
  member this.SystemCollectionsGenericDict() =
    let a = Collections.Generic.Dictionary<_,_>()
    let sz = this.Size
    for i = 0 to sz do
      a.Add((sz - i), i + i)
    a

  [<Benchmark>]
  member this.SystemCollectionsImm() =
    let mutable a = Collections.Immutable.ImmutableDictionary.Empty
    let sz = this.Size
    for i = 0 to sz do
      a <- a.Add((sz - i), (i + i))
    a

  [<Benchmark>]
  member this.FSharpMap() =
    let mutable a = Map.empty
    let sz = this.Size
    for i = 0 to sz do
      a <- Map.add (sz - i) (i + i) a
    a

  [<Benchmark>]
  member this.ImmMap() =
    let mutable a = ImmMap.empty
    let sz = this.Size
    for i = 0 to sz do
      a <- ImmMap.set (sz - i) (i + i) a
    a

  [<Benchmark>]
  member this.PrimeVMap() =
    let mutable a = Vmap.makeEmpty()
    let sz = this.Size
    for i = 0 to sz do
      a <- Vmap.add (sz - i) (i + i) a
    a

  [<Benchmark>]
  member this.PrimeUMap() =
    let mutable a = Umap.makeEmpty(None)
    let sz = this.Size
    for i = 0 to sz do
      a <- Umap.add (sz - i) (i + i) a
    a
