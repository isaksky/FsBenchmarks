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
      dict |  45.7728 ns | 0.9192 ns |   1.00 |      0.00 |   0.26 |  0.13 |     - |               0.05 |
     fsmap | 232.4820 ns | 7.8520 ns |   5.14 |      0.19 |   2.00 |  1.00 |     - |               0.38 |
    immMap | 182.3140 ns | 7.0238 ns |   3.97 |      0.17 |   1.04 |  0.52 |     - |               0.20 |
 primeVmap | 133.0015 ns | 2.3012 ns |   2.88 |      0.07 | 399.40 |  0.23 |     - |              16.42 |
 primeUmap |  78.2537 ns | 1.7675 ns |   1.70 |      0.05 | 417.75 |  0.25 |     - |              17.19 |
