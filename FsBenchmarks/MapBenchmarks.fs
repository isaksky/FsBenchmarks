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

type DictEntry<'k,'v when 'k: comparison> =
  { dict: Collections.Generic.Dictionary<'k, 'v>
    fsmap: Map<'k,'v>
    immMap: ImmMap<'k, 'v>
    primeVmap: Vmap<'k, 'v>
    primeUmap: Umap<'k, 'v> }

let [<Literal>] NUM_MAPS = 1000

type LookupInOldMaps() =

  let entries = ResizeArray<DictEntry<_,_>>(NUM_MAPS) 
  let rand = System.Random()

  do
    let startEntry : DictEntry<int,int> =  
      {dict= Collections.Generic.Dictionary<int,int>()
       fsmap = Map.empty
       immMap = ImmMap.empty
       primeVmap = Vmap.makeEmpty()
       primeUmap = Umap.makeEmpty(None) }
    entries.Add(startEntry)
    
    let addRetDict (k:'k) (v:'v) (d: Collections.Generic.Dictionary<'k,'v>) =
      d.[k] <- v; d
       
    let mutable lastEntry = startEntry

    for i = 0 to NUM_MAPS do
      let k = rand.Next(0, NUM_MAPS)
      let v = rand.Next()
      let entry =
        { lastEntry with
            dict = addRetDict k v (lastEntry.dict)
            fsmap = Map.add k v (lastEntry.fsmap)
            immMap = ImmMap.set k v (lastEntry.immMap)
            primeVmap = Vmap.add k v (lastEntry.primeVmap)
            primeUmap = Umap.add k v (lastEntry.primeUmap)
          }
      entries.Add(entry)
      lastEntry <- entry

  member val public Size = NUM_MAPS with get, set
  
  member this.randEntry() =
    entries.[(rand.Next(0, entries.Count))] 

  [<Benchmark(Baseline=true)>]
  member this.dict() =
    let k = rand.Next(0, NUM_MAPS)
    let ok, _v = this.randEntry().dict.TryGetValue(k)
    ok

  [<Benchmark>]
  member this.fsmap() =
    let k = rand.Next(0, NUM_MAPS)
    Map.tryFind k (this.randEntry().fsmap)

  [<Benchmark>]
  member this.immMap() =
    let k = rand.Next(0, NUM_MAPS)
    ImmMap.tryGet k (this.randEntry().immMap)

  [<Benchmark>]
  member this.primeVmap() =
    let k = rand.Next(0, NUM_MAPS)
    Vmap.tryFind k (this.randEntry().primeVmap) 

  [<Benchmark>]
  member this.primeUmap() =
    let k = rand.Next(0, NUM_MAPS)
    Umap.tryFind k (this.randEntry().primeUmap)