```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-6600U CPU 2.60GHz, ProcessorCount=4
Frequency=2742188 ticks, Resolution=364.6723 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1080.0

Type=LookupInMapMiss  Mode=Throughput  

```
        Method |      Median |    StdDev | Scaled | Scaled-SD |  Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
-------------- |------------ |---------- |------- |---------- |------- |------ |------ |------------------- |
      dictMiss |  31.6151 ns | 1.1278 ns |   1.00 |      0.00 |   0.53 |  0.27 |     - |               0.05 |
     fsmapMiss | 168.1626 ns | 4.4829 ns |   5.24 |      0.22 |   2.00 |  1.00 |     - |               0.19 |
    immMapMiss |  52.7447 ns | 2.0740 ns |   1.65 |      0.08 |   1.04 |  0.52 |     - |               0.10 |
 primeVmapMiss |  40.6622 ns | 1.9187 ns |   1.27 |      0.07 |   0.54 |  0.27 |     - |               0.05 |
 primeUmapMiss |  50.1950 ns | 1.1260 ns |   1.57 |      0.06 | 298.41 |  0.49 |     - |               6.19 |
