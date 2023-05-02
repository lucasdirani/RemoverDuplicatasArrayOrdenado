``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                 Method |     Array |      Mean |     Error |    StdDev | Rank |   Gen0 | Allocated |
|------------------------------------------------------- |---------- |----------:|----------:|----------:|-----:|-------:|----------:|
| **MedirPerformanceRemoverDuplicatasUsandoEspaçoConstante** | **Int32[11]** | **18.602 ns** | **0.4043 ns** | **0.4493 ns** |    **2** |      **-** |         **-** |
|     MedirPerformanceRemoverDuplicatasUsandoEspaçoExtra | Int32[11] | 34.676 ns | 0.6995 ns | 0.8056 ns |    4 | 0.0172 |      72 B |
| **MedirPerformanceRemoverDuplicatasUsandoEspaçoConstante** | **Int32[17]** | **30.483 ns** | **0.5762 ns** | **0.5389 ns** |    **3** |      **-** |         **-** |
|     MedirPerformanceRemoverDuplicatasUsandoEspaçoExtra | Int32[17] | 49.932 ns | 0.9575 ns | 0.8956 ns |    5 | 0.0229 |      96 B |
| **MedirPerformanceRemoverDuplicatasUsandoEspaçoConstante** |  **Int32[5]** |  **8.442 ns** | **0.1128 ns** | **0.0942 ns** |    **1** |      **-** |         **-** |
|     MedirPerformanceRemoverDuplicatasUsandoEspaçoExtra |  Int32[5] | 18.404 ns | 0.4056 ns | 0.8007 ns |    2 | 0.0115 |      48 B |
