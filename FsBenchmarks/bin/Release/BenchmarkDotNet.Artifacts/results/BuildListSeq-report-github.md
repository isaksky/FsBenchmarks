```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-6600U CPU 2.60GHz, ProcessorCount=4
Frequency=2742193 ticks, Resolution=364.6716 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1080.0

Type=BuildListSeq  Mode=Throughput  

```
                Method |  Size |            Median |          StdDev | Scaled | Scaled-SD |  Gen 0 |  Gen 1 | Gen 2 | Bytes Allocated/Op |
---------------------- |------ |------------------ |---------------- |------- |---------- |------- |------- |------ |------------------- |
           **ResizeArray** |   **100** |       **679.5608 ns** |      **59.0342 ns** |   **1.00** |      **0.00** |   **0.47** |      **-** |     **-** |             **464.61** |
  SystemCollectionsImm |   100 |    25,924.3159 ns |     636.6121 ns |  37.37 |      2.98 |   9.33 |      - |     - |           9,089.47 |
 FSharpListBuildAndRev |   100 |       855.3992 ns |      65.9594 ns |   1.27 |      0.13 |   1.41 |      - |     - |           1,367.36 |
               ImmList |   100 |    10,250.4914 ns |     716.4173 ns |  14.97 |      1.53 |   8.28 |      - |     - |           8,037.91 |
                 Ulist |   100 |     5,409.4331 ns |     326.8556 ns |   7.84 |      0.76 |   5.18 |      - |     - |           5,038.10 |
           **ResizeArray** |  **1000** |     **3,876.6643 ns** |     **281.9968 ns** |   **1.00** |      **0.00** |   **3.74** |      **-** |     **-** |           **4,250.30** |
  SystemCollectionsImm |  1000 |   383,242.3759 ns |  18,025.1204 ns |  97.94 |      7.64 | 109.38 |      - |     - |         106,383.10 |
 FSharpListBuildAndRev |  1000 |     8,595.7415 ns |     351.4005 ns |   2.18 |      0.16 |  14.49 |      - |     - |          14,041.94 |
               ImmList |  1000 |   114,754.8446 ns |   3,193.1975 ns |  28.99 |      1.99 |  79.11 |      - |     - |          77,089.36 |
                 Ulist |  1000 |    59,541.9924 ns |   3,781.5930 ns |  15.16 |      1.35 |  44.86 |      - |     - |          44,058.37 |
           **ResizeArray** | **10000** |    **36,230.4962 ns** |     **952.6871 ns** |   **1.00** |      **0.00** |  **61.24** |      **-** |     **-** |          **65,875.90** |
  SystemCollectionsImm | 10000 | 6,063,084.7053 ns | 514,291.4771 ns | 170.60 |     14.60 | 898.00 | 401.00 |     - |       1,765,616.69 |
 FSharpListBuildAndRev | 10000 |   125,719.4772 ns |   3,429.0793 ns |   3.49 |      0.13 |  91.00 |  37.30 |     - |         159,010.63 |
               ImmList | 10000 | 1,579,374.3251 ns |  57,062.0961 ns |  43.58 |      1.89 | 353.26 |  95.32 |     - |         696,284.52 |
                 Ulist | 10000 |   865,875.0439 ns |  34,892.4933 ns |  23.99 |      1.12 |  76.38 |  58.07 |     - |         285,833.98 |
