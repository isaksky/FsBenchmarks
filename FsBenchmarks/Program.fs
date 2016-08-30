open BenchmarkDotNet
open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open BenchmarkDotNet.Diagnosers
open BenchmarkDotNet.Configs
open BenchmarkDotNet.Diagnostics.Windows


type Cfg() as this =
  inherit ManualConfig()
  do this.Add(new MemoryDiagnoser())

[<assembly:Config(typeof<Cfg>)>] do()


let defaultSwitch () = 
  BenchmarkSwitcher [| 
    typeof<ListBenchmarks.BuildListSeq>;
    typeof<MapBenchmarks.BuildMapSeq>;
    typeof<ListBenchmarks.SwitchFirst2> |]

[<EntryPoint>]
let main argv =
  let _summary = defaultSwitch().Run argv
  0 