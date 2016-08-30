```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-6600U CPU 2.60GHz, ProcessorCount=4
Frequency=2742188 ticks, Resolution=364.6723 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1080.0

Type=SwitchFirst2  Mode=Throughput  

```
  Method | Size |         Median |      StdDev |    Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
-------- |----- |--------------- |------------ |--------- |------ |------ |------------------- |
  fsList |  100 |    924.4414 ns |  21.6695 ns |   249.21 |     - |     - |           1,425.01 |
 ImmList |  100 | 27,116.2032 ns | 575.2809 ns | 3,890.00 |     - |     - |          22,249.60 |
