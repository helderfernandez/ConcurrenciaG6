```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5131/22H2/2022Update)
AMD FX-9800P RADEON R7, 12 COMPUTE CORES 4C+8G, 1 CPU, 4 logical and 4 physical cores
  [Host]     : .NET Framework 4.8.1 (4.8.9282.0), X86 LegacyJIT [AttachedDebugger]
  DefaultJob : .NET Framework 4.8.1 (4.8.9282.0), X86 LegacyJIT


```
| Method                       | Mean       | Error     | StdDev    | Ratio |
|----------------------------- |-----------:|----------:|----------:|------:|
| HolaMundobase                | 110.363 ms | 0.7700 ms | 0.7202 ms |  1.00 |
| HolaMundoRefactorizado       | 158.024 ms | 1.2065 ms | 1.1285 ms |  1.43 |
| PruebaPerformRNCliente       |   5.795 ms | 0.1122 ms | 0.1200 ms |  0.05 |
| InsertarClienteNaturalAsiync |   5.594 ms | 0.1069 ms | 0.1982 ms |  0.05 |
