```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-6600U CPU 2.60GHz, ProcessorCount=4
Frequency=2742188 ticks, Resolution=364.6723 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1080.0

Type=LookupInOldMaps  Mode=Throughput  

```
    Method |      Median |    StdDev | Scaled | Scaled-SD |  Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
---------- |------------ |---------- |------- |---------- |------- |------ |------ |------------------- |
  dictMiss |  82.0039 ns | 4.2164 ns |   1.00 |      0.00 |      - |     - |     - |               0.01 |
     fsmap | 215.4286 ns | 5.7570 ns |   2.61 |      0.14 |  37.44 |     - |     - |               1.79 |
    immMap | 178.5501 ns | 4.2322 ns |   2.15 |      0.12 |  40.34 |     - |     - |               1.94 |
 primeVmap | 113.6700 ns | 5.2067 ns |   1.37 |      0.09 | 145.50 |     - |     - |               6.21 |
 primeUmap | 249.7497 ns | 7.1274 ns |   3.04 |      0.17 | 221.00 |  2.00 |     - |              10.11 |
