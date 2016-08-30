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
           **ResizeArray** |   **100** |       **713.7460 ns** |      **55.6604 ns** |   **1.00** |      **0.00** |     **0.65** |      **-** |     **-** |             **483.57** |
  SystemCollectionsImm |   100 |    25,998.3037 ns |     543.1280 ns |  36.07 |      2.84 |    12.02 |      - |     - |           8,844.64 |
 FSharpListBuildAndRev |   100 |       858.8539 ns |      63.0214 ns |   1.22 |      0.13 |     1.83 |      - |     - |           1,344.28 |
               ImmList |   100 |    10,047.5465 ns |     160.9207 ns |  13.84 |      1.07 |    10.91 |      - |     - |           7,995.64 |
           **ResizeArray** |  **1000** |     **3,626.6575 ns** |      **69.6127 ns** |   **1.00** |      **0.00** |     **4.73** |      **-** |     **-** |           **4,058.45** |
  SystemCollectionsImm |  1000 |   373,545.1598 ns |  18,025.4968 ns | 103.44 |      5.20 |   140.55 |      - |     - |         103,253.31 |
 FSharpListBuildAndRev |  1000 |     8,581.1700 ns |     187.4700 ns |   2.34 |      0.07 |    19.30 |      - |     - |          14,122.16 |
               ImmList |  1000 |   113,146.2579 ns |   2,550.9840 ns |  30.80 |      0.88 |    96.37 |      - |     - |          70,923.02 |
           **ResizeArray** | **10000** |    **36,856.7864 ns** |   **2,271.7914 ns** |   **1.00** |      **0.00** |    **84.14** |      **-** |     **-** |          **68,388.11** |
  SystemCollectionsImm | 10000 | 5,803,922.0186 ns | 139,400.9078 ns | 154.61 |      9.42 | 1,101.00 | 456.00 |     - |       1,635,010.92 |
 FSharpListBuildAndRev | 10000 |   120,576.1888 ns |   2,837.2677 ns |   3.25 |      0.20 |   104.18 |  42.62 |     - |         137,432.36 |
               ImmList | 10000 | 1,518,486.1904 ns |  29,432.5802 ns |  40.48 |      2.40 |   399.80 | 107.90 |     - |         595,295.48 |
