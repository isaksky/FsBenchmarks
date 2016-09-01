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
    Method |      Median |     StdDev | Scaled | Scaled-SD |  Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
---------- |------------ |----------- |------- |---------- |------- |------ |------ |------------------- |
      dict |  80.9983 ns |  1.7284 ns |   1.00 |      0.00 |      - |     - |     - |               0.01 |
     fsmap | 213.8007 ns | 14.9382 ns |   2.74 |      0.19 |  41.00 |     - |     - |               1.99 |
    immMap | 175.7655 ns |  9.2337 ns |   2.22 |      0.12 |  39.81 |     - |     - |               1.91 |
 primeVmap | 130.9478 ns |  5.3403 ns |   1.64 |      0.07 | 135.42 |     - |     - |               6.23 |
 primeUmap | 292.6952 ns | 16.2444 ns |   3.64 |      0.21 | 177.23 |  1.96 |     - |               8.42 |
