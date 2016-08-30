```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-6600U CPU 2.60GHz, ProcessorCount=4
Frequency=2742188 ticks, Resolution=364.6723 ns, Timer=TSC
CLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1080.0

Type=BuildMapSeq  Mode=Throughput  

```
                       Method |  Size |         Median |      StdDev | Scaled | Scaled-SD |  Gen 0 |  Gen 1 | Gen 2 | Bytes Allocated/Op |
----------------------------- |------ |--------------- |------------ |------- |---------- |------- |------- |------ |------------------- |
 **SystemCollectionsGenericDict** |   **100** |      **2.8578 us** |   **0.0642 us** |   **1.00** |      **0.00** |   **1.49** |      **-** |     **-** |           **3,138.74** |
         SystemCollectionsImm |   100 |     77.4175 us |   4.8445 us |  28.01 |      1.80 |   6.44 |      - |     - |          12,364.74 |
                    FSharpMap |   100 |     38.9328 us |   1.0895 us |  13.85 |      0.48 |   4.61 |      - |     - |           8,746.64 |
                       ImmMap |   100 |     25.5021 us |   1.3547 us |   9.09 |      0.51 |  10.20 |      - |     - |          19,316.19 |
                    PrimeVMap |   100 |     15.6606 us |   0.3755 us |   5.57 |      0.18 |   7.46 |      - |     - |          14,190.26 |
                    PrimeUMap |   100 |      7.8568 us |   0.1881 us |   2.74 |      0.09 |   3.77 |      - |     - |           7,468.35 |
 **SystemCollectionsGenericDict** |  **1000** |     **25.3865 us** |   **2.0774 us** |   **1.00** |      **0.00** |  **15.36** |      **-** |     **-** |          **35,895.74** |
         SystemCollectionsImm |  1000 |  1,101.5596 us |  28.8512 us |  42.04 |      3.26 |  63.40 |      - |     - |         120,951.27 |
                    FSharpMap |  1000 |    632.0978 us |  11.9314 us |  24.16 |      1.82 |  61.92 |      - |     - |         118,383.60 |
                       ImmMap |  1000 |    394.2389 us |  31.8998 us |  15.29 |      1.64 | 125.09 |      - |     - |         237,138.39 |
                    PrimeVMap |  1000 |    193.9116 us |   4.6906 us |   7.52 |      0.58 |  79.99 |      - |     - |         152,639.75 |
                    PrimeUMap |  1000 |     80.3324 us |   1.5338 us |   3.06 |      0.23 |  36.13 |      - |     - |          74,603.05 |
 **SystemCollectionsGenericDict** | **10000** |    **329.9152 us** |  **18.0392 us** |   **1.00** |      **0.00** |      **-** |      **-** | **49.14** |         **250,082.70** |
         SystemCollectionsImm | 10000 | 15,446.4587 us | 417.1799 us |  47.10 |      2.78 | 376.00 | 130.00 |     - |       1,577,725.19 |
                    FSharpMap | 10000 |  9,425.1493 us | 231.0269 us |  28.99 |      1.68 | 662.19 | 120.27 |     - |       1,773,985.09 |
                       ImmMap | 10000 |  7,339.8448 us | 378.0445 us |  22.60 |      1.65 | 372.48 | 184.81 | 42.10 |       2,954,467.98 |
                    PrimeVMap | 10000 |  3,650.6689 us |  86.1968 us |  11.02 |      0.64 | 204.70 | 113.94 |     - |       1,422,970.69 |
                    PrimeUMap | 10000 |  1,345.5254 us |  26.2622 us |   4.06 |      0.23 |  67.14 |  23.35 | 61.51 |         801,892.54 |
