```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-6600U CPU 2.60GHz, ProcessorCount=4
Frequency=2742193 ticks, Resolution=364.6716 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1080.0

Type=LookupInMapHit  Mode=Throughput  

```
    Method |      Median |    StdDev | Scaled | Scaled-SD |  Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
---------- |------------ |---------- |------- |---------- |------- |------ |------ |------------------- |
      dict |  48.3665 ns | 3.0666 ns |   1.00 |      0.00 |   0.24 |  0.12 |     - |               0.05 |
     fsmap | 239.8859 ns | 9.9293 ns |   4.96 |      0.36 |   2.00 |  1.00 |     - |               0.40 |
    immMap | 184.4154 ns | 9.0846 ns |   3.83 |      0.30 |   0.92 |  0.46 |     - |               0.18 |
 primeVmap | 136.9483 ns | 3.6702 ns |   2.80 |      0.18 | 324.00 |  0.50 |     - |              14.01 |
 primeUmap |  56.1783 ns | 1.4253 ns |   1.16 |      0.08 | 150.63 |  0.23 |     - |               6.51 |
