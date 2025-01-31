```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5131/22H2/2022Update)
AMD FX-9800P RADEON R7, 12 COMPUTE CORES 4C+8G, 1 CPU, 4 logical and 4 physical cores
  [Host]     : .NET Framework 4.8.1 (4.8.9282.0), X86 LegacyJIT [AttachedDebugger]
  DefaultJob : .NET Framework 4.8.1 (4.8.9282.0), X86 LegacyJIT


```
| Method           | Mean           | Error       | StdDev      |
|----------------- |---------------:|------------:|------------:|
| Primo            |      0.6767 ns |   0.0529 ns |   0.0495 ns |
| PrimoAsync       | 35,964.2031 ns | 717.3760 ns | 932.7915 ns |
| PrimoMultinucleo |      6.3583 ns |   0.0895 ns |   0.0747 ns |
