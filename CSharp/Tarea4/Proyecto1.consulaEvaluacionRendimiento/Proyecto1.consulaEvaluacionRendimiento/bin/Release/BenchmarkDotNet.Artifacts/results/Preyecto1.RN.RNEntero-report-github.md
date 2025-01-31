```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5131/22H2/2022Update)
AMD FX-9800P RADEON R7, 12 COMPUTE CORES 4C+8G, 1 CPU, 4 logical and 4 physical cores
  [Host]     : .NET Framework 4.8.1 (4.8.9282.0), X86 LegacyJIT [AttachedDebugger]
  DefaultJob : .NET Framework 4.8.1 (4.8.9282.0), X86 LegacyJIT


```
| Method        | Mean           | Error       | StdDev      |
|-------------- |---------------:|------------:|------------:|
| Primo         |      0.0000 ns |   0.0000 ns |   0.0000 ns |
| PrimoAsync    | 46,498.7821 ns | 779.3648 ns | 729.0183 ns |
| PrimoParalelo |     11.2459 ns |   1.1516 ns |   3.3956 ns |
