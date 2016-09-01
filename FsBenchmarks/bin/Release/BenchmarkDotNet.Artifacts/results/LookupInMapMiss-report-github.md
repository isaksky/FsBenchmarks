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
      dictMiss |  32.2286 ns | 0.8137 ns |   1.00 |      0.00 |   0.60 |  0.30 |     - |               0.05 |
     fsmapMiss | 168.8917 ns | 4.1554 ns |   5.15 |      0.18 |   2.00 |  1.00 |     - |               0.17 |
    immMapMiss |  49.8266 ns | 0.9238 ns |   1.55 |      0.05 |   1.02 |  0.51 |     - |               0.09 |
 primeVmapMiss |  40.4321 ns | 2.6664 ns |   1.26 |      0.09 |   0.60 |  0.30 |     - |               0.05 |
 primeUmapMiss |  52.5370 ns | 3.3153 ns |   1.64 |      0.11 | 385.57 |  0.57 |     - |               7.11 |
