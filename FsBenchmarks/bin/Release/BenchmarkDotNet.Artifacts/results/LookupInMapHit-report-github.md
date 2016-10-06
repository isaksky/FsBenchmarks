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
      dict |  46.3606 ns | 0.7887 ns |   1.00 |      0.00 |   0.52 |  0.26 |     - |               0.10 |
     fsmap | 242.6756 ns | 4.5738 ns |   5.22 |      0.13 |   2.00 |  1.00 |     - |               0.40 |
    immMap | 185.9602 ns | 6.1605 ns |   4.03 |      0.15 |   1.02 |  0.51 |     - |               0.20 |
 primeVmap | 118.8416 ns | 2.7682 ns |   2.57 |      0.07 | 223.47 |  0.44 |     - |               9.71 |
 primeUmap |  56.9156 ns | 0.9829 ns |   1.23 |      0.03 | 180.20 |  0.10 |     - |               7.72 |
