```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-6600U CPU 2.60GHz, ProcessorCount=4
Frequency=2742188 ticks, Resolution=364.6723 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1080.0

Type=LookupInMapHit  Mode=Throughput  

```
    Method |      Median |    StdDev | Scaled | Scaled-SD |  Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
---------- |------------ |---------- |------- |---------- |------- |------ |------ |------------------- |
      dict |  46.5128 ns | 3.7095 ns |   1.00 |      0.00 |   0.26 |  0.13 |     - |               0.05 |
     fsmap | 235.5805 ns | 6.0327 ns |   5.06 |      0.37 |   2.00 |  1.00 |     - |               0.39 |
    immMap | 184.8130 ns | 4.2090 ns |   3.89 |      0.28 |   0.86 |  0.43 |     - |               0.17 |
 primeVmap |  87.0383 ns | 1.8573 ns |   1.85 |      0.13 | 367.66 |  0.26 |     - |              15.45 |
 primeUmap |  75.7116 ns | 3.9966 ns |   1.65 |      0.14 | 455.29 |  0.24 |     - |              19.11 |
