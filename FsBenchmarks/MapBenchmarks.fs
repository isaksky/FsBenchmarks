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

type LookupInMapHit() =
  let mutable _dict = Collections.Generic.Dictionary<_,_>()
  let mutable _fsmap = Map.empty
  let mutable _immMap = ImmMap.empty
  let mutable _primeVmap = Vmap.makeEmpty()
  let mutable _primeUmap = Umap.makeEmpty(None)
  let rand = System.Random()

  do
    for i = 0 to 10000 do
      let k = i + 100
      let v = i + i
      _dict.Add(k, v)
      _fsmap <- Map.add k v _fsmap
      _immMap <- ImmMap.add k v _immMap
      _primeVmap <- Vmap.add k v _primeVmap
      _primeUmap <- Umap.add k v _primeUmap

  member val public Size = 10000 with get, set

  [<Benchmark(Baseline=true)>]
  member this.dict() =
    let k = rand.Next(100, this.Size)
    _dict.[k]

  [<Benchmark>]
  member this.fsmap() =
    let k = rand.Next(100, this.Size)
    _fsmap.[k]

  [<Benchmark>]
  member this.immMap() =
    let k = rand.Next(100, this.Size)
    _immMap.[k]

  [<Benchmark>]
  member this.primeVmap() =
    let k = rand.Next(100, this.Size)
    Vmap.find k _primeVmap

  [<Benchmark>]
  member this.primeUmap() =
    let k = rand.Next(100, this.Size)
    Umap.find k _primeUmap

type LookupInMapMiss() =
  let mutable _dict = Collections.Generic.Dictionary<_,_>()
  let mutable _fsmap = Map.empty
  let mutable _immMap = ImmMap.empty
  let mutable _primeVmap = Vmap.makeEmpty()
  let mutable _primeUmap = Umap.makeEmpty(None)
  let rand = System.Random()

  do
    for i = 0 to 10000 do
      let k = i + 100
      let v = i + i
      _dict.Add(k, v)
      _fsmap <- Map.add k v _fsmap
      _immMap <- ImmMap.add k v _immMap
      _primeVmap <- Vmap.add k v _primeVmap
      _primeUmap <- Umap.add k v _primeUmap

  member val public Size = 10000 with get, set

  [<Benchmark(Baseline=true)>]
  member this.dictMiss() =
    let k = rand.Next(0, 100)
    let ok, _v = _dict.TryGetValue(k)
    ok

  [<Benchmark>]
  member this.fsmapMiss() =
    let k = rand.Next(0, 100)
    Map.tryFind k _fsmap

  [<Benchmark>]
  member this.immMapMiss() =
    let k = rand.Next(0, 100)
    ImmMap.tryGet k _immMap

  [<Benchmark>]
  member this.primeVmapMiss() =
    let k = rand.Next(0, 100)
    Vmap.tryFind k _primeVmap

  [<Benchmark>]
  member this.primeUmapMiss() =
    let k = rand.Next(0, 100)
    Umap.tryFind k _primeUmap