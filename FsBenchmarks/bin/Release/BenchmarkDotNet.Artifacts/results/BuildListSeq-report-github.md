```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-6600U CPU 2.60GHz, ProcessorCount=4
Frequency=2742188 ticks, Resolution=364.6723 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1080.0

Type=BuildListSeq  Mode=Throughput  

```
                Method |  Size |            Median |          StdDev | Scaled | Scaled-SD |    Gen 0 |  Gen 1 | Gen 2 | Bytes Allocated/Op |
---------------------- |------ |------------------ |---------------- |------- |---------- |--------- |------- |------ |------------------- |
           **ResizeArray** |   **100** |       **631.5830 ns** |      **15.3669 ns** |   **1.00** |      **0.00** |     **0.98** |      **-** |     **-** |             **508.85** |
  SystemCollectionsImm |   100 |    25,134.7610 ns |     555.5012 ns |  39.99 |      1.27 |    16.15 |      - |     - |           8,223.99 |
 FSharpListBuildAndRev |   100 |       851.6528 ns |      66.5642 ns |   1.38 |      0.11 |     2.61 |      - |     - |           1,321.83 |
               ImmList |   100 |     9,586.7537 ns |     463.6579 ns |  15.57 |      0.80 |    15.01 |      - |     - |           7,614.94 |
           **ResizeArray** |  **1000** |     **3,708.2798 ns** |     **189.8403 ns** |   **1.00** |      **0.00** |     **6.84** |      **-** |     **-** |           **4,058.45** |
  SystemCollectionsImm |  1000 |   373,354.6328 ns |   8,484.0088 ns |  98.32 |      5.05 |   232.65 |      - |     - |         118,264.75 |
 FSharpListBuildAndRev |  1000 |     8,285.2966 ns |     234.4839 ns |   2.24 |      0.12 |    25.93 |      - |     - |          13,130.18 |
               ImmList |  1000 |   112,699.7658 ns |   2,974.1702 ns |  29.83 |      1.58 |   185.77 |      - |     - |          94,561.97 |
           **ResizeArray** | **10000** |    **36,037.7872 ns** |   **2,690.3979 ns** |   **1.00** |      **0.00** |   **113.32** |      **-** |     **-** |          **63,742.88** |
  SystemCollectionsImm | 10000 | 5,679,141.4146 ns | 164,869.7195 ns | 155.42 |     11.31 | 1,101.00 | 456.00 |     - |       1,131,549.16 |
 FSharpListBuildAndRev | 10000 |   121,211.2493 ns |   9,136.6750 ns |   3.42 |      0.34 |   144.64 |  59.17 |     - |         132,042.65 |
               ImmList | 10000 | 1,480,656.4252 ns |  30,351.3042 ns |  40.90 |      2.86 |   899.75 | 225.28 |     - |         886,718.13 |
