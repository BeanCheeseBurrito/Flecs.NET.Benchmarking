# Flecs.NET.Benchmarking
This repo is a collection of performance benchmarks for [Flecs.NET](https://github.com/BeanCheeseBurrito/Flecs.NET).

## Running The Benchmark Program
```console
dotnet restore
```

```console
dotnet run --project Flecs.NET.Benchmarking -c Release
```

## Results
| Benchmark                           | Total      | Average    |
| ----------------------------------- | ---------- | ---------- |
| Has Empty Entity                    | 6.90 ns    | 6.90 ns    |
| Has Id Not Found                    | 10.19 ns   | 10.19 ns   |
| Has 1 Id                            | 12.98 ns   | 12.98 ns   |
| Has 16 Ids                          | 166.02 ns  | 10.38 ns   |
| Get Empty Entity                    | 7.28 ns    | 7.28 ns    |
| Get Id Not Found                    | 14.45 ns   | 14.45 ns   |
| Get 1 Id                            | 13.12 ns   | 13.12 ns   |
| Get 16 Ids                          | 172.70 ns  | 10.79 ns   |
| Get Pair                            | 16.83 ns   | 16.83 ns   |
| Get Pair 16 Targets                 | 217.30 ns  | 13.58 ns   |
| Get Inherited Depth 1               | 39.26 ns   | 39.26 ns   |
| Get Inherited Depth 2               | 50.73 ns   | 50.73 ns   |
| Get Inherited Depth 16              | 275.09 ns  | 275.09 ns  |
| Get Inherited Depth 32              | 579.48 ns  | 579.48 ns  |
| Get Mut 1 Id                        | 20.60 ns   | 20.60 ns   |
| Get Mut 16 Ids                      | 303.66 ns  | 18.98 ns   |
| Set 1 Id                            | 28.80 ns   | 28.80 ns   |
| Set 16 Ids                          | 377.69 ns  | 23.61 ns   |
| Get Mut Remove 1 Id                 | 82.41 ns   | 41.20 ns   |
| Get Mut Remove 16 Ids               | 3.33 us    | 104.01 ns  |
| Get Mut Remove 32 Ids               | 10.48 us   | 163.76 ns  |
| Add Remove 1 Tag                    | 63.50 ns   | 31.75 ns   |
| Add Remove 2 Tags                   | 148.34 ns  | 37.09 ns   |
| Add Remove 16 Tags                  | 1.46 us    | 45.76 ns   |
| Add Remove 32 Tags                  | 3.10 us    | 48.43 ns   |
| Add Remove 1 Component              | 60.91 ns   | 30.45 ns   |
| Add Remove 2 Components             | 167.97 ns  | 41.99 ns   |
| Add Remove 16 Components            | 3.01 us    | 93.92 ns   |
| Add Remove 32 Components            | 9.84 us    | 153.76 ns  |
| Add Existing 1 Tag                  | 17.72 ns   | 17.72 ns   |
| Add Existing 16 Tags                | 252.21 ns  | 15.76 ns   |
| Add Existing 1 Component            | 15.34 ns   | 15.34 ns   |
| Add Existing 16 Components          | 246.26 ns  | 15.39 ns   |
| Add Remove Tag To 1 Component       | 100.09 ns  | 50.04 ns   |
| Add Remove Tag To 4 Components      | 135.79 ns  | 67.89 ns   |
| Add Remove Tag To 8 Components      | 196.58 ns  | 98.29 ns   |
| Add Remove Tag To 16 Components     | 289.75 ns  | 144.88 ns  |
| Add Remove Tag To 64 Components     | 965.53 ns  | 482.76 ns  |
| Add Remove Override 1               | 284.69 ns  | 142.34 ns  |
| Add Remove Override 2               | 585.52 ns  | 146.38 ns  |
| Add Remove Override 4               | 1.27 us    | 159.01 ns  |
| Add Remove Override 16              | 7.13 us    | 222.78 ns  |
| Add Remove Cmd 1 Tag                | 99.37 ns   | 49.68 ns   |
| Add Remove Cmd 2 Tags               | 168.15 ns  | 42.04 ns   |
| Add Remove Cmd 16 Tags              | 1.01 us    | 31.54 ns   |
| Add Remove Cmd 32 Tags              | 1.98 us    | 30.89 ns   |
| Add Remove Cmd 1 Components         | 99.48 ns   | 49.74 ns   |
| Add Remove Cmd 2 Components         | 173.11 ns  | 43.28 ns   |
| Add Remove Cmd 16 Components        | 1.06 us    | 33.15 ns   |
| Add Remove Cmd 32 Components        | 2.07 us    | 32.32 ns   |
| Get Mut Cmd 1                       | 53.21 ns   | 53.21 ns   |
| Get Mut Cmd 2                       | 94.72 ns   | 47.36 ns   |
| Get Mut Cmd 16                      | 656.63 ns  | 41.04 ns   |
| Get Mut Cmd 32                      | 1.30 us    | 40.56 ns   |
| Set Cmd 1                           | 76.60 ns   | 76.60 ns   |
| Set Cmd 2                           | 157.45 ns  | 78.72 ns   |
| Set Cmd 16                          | 1.15 us    | 71.58 ns   |
| Set Cmd 32                          | 2.30 us    | 71.84 ns   |
| Get Mut Remove Cmd 1                | 131.22 ns  | 65.61 ns   |
| Get Mut Remove Cmd 2                | 242.28 ns  | 60.57 ns   |
| Get Mut Remove Cmd 16               | 1.60 us    | 49.98 ns   |
| Get Mut Remove Cmd 32               | 3.14 us    | 49.09 ns   |
| Create Delete empty                 | 42.23 ns   | 21.12 ns   |
| Create Delete 1 Tag                 | 75.30 ns   | 25.10 ns   |
| Create Delete 2 Tags                | 123.40 ns  | 30.85 ns   |
| Create Delete 16 Tags               | 783.18 ns  | 43.51 ns   |
| Create Delete 1 Component           | 78.46 ns   | 26.15 ns   |
| Create Delete 2 Components          | 133.41 ns  | 33.35 ns   |
| Create Delete 16 Components         | 1.50 us    | 83.58 ns   |
| Create Delete Tree W1 D1            | 2.20 us    | 2.20 us    |
| Create Delete Tree W1 D10           | 15.65 us   | 15.65 us   |
| Create Delete Tree W1 D100          | 153.14 us  | 153.14 us  |
| Create Delete Tree W1 D1000         | 1.80 ms    | 1.80 ms    |
| Create Delete Tree W10 D1           | 289.72 ns  | 289.72 ns  |
| Create Delete Tree W10 D10          | 2.35 us    | 2.35 us    |
| Create Delete Tree W10 D100         | 23.16 us   | 23.16 us   |
| Create Delete Tree W10 D1000        | 250.66 us  | 250.66 us  |
| Create Delete Tree W100 D1          | 88.14 ns   | 88.14 ns   |
| Create Delete Tree W100 D10         | 832.98 ns  | 832.98 ns  |
| Create Delete Tree W100 D100        | 8.39 us    | 8.39 us    |
| Create Delete Tree W100 D1000       | 96.68 us   | 96.68 us   |
| Create Delete Tree W1000 D1         | 65.23 ns   | 65.23 ns   |
| Create Delete Tree W1000 D10        | 668.93 ns  | 668.93 ns  |
| Create Delete Tree W1000 D100       | 7.19 us    | 7.19 us    |
| Create Delete Tree W1000 D1000      | 76.79 us   | 76.79 us   |
| Query Iter 1 Table 1 Tag            | 95.42 us   | 95.42 us   |
| Query Iter 2 Tables 1 Tag           | 89.43 us   | 89.43 us   |
| Query Iter 4 Tables 1 Tag           | 89.65 us   | 89.65 us   |
| Query Iter 8 Tables 1 Tag           | 89.36 us   | 89.36 us   |
| Query Iter 16 Tables 1 Tag          | 90.00 us   | 90.00 us   |
| Query Iter 32 Tables 1 Tag          | 90.00 us   | 90.00 us   |
| Query Iter 64 Tables 1 Tag          | 90.40 us   | 90.40 us   |
| Query Iter 128 Tables 1 Tag         | 92.23 us   | 92.23 us   |
| Query Iter 256 Tables 1 Tag         | 94.64 us   | 94.64 us   |
| Query Iter 512 Tables 1 Tag         | 99.37 us   | 99.37 us   |
| Query Iter 1024 Tables 1 Tag        | 103.18 us  | 103.18 us  |
| Query Iter 4096 Tables 1 Tag        | 165.04 us  | 165.04 us  |
| Query Iter 4096 Tables 4 Tags       | 162.76 us  | 162.76 us  |
| Query Iter 4096 Tables 4 comps      | 290.40 us  | 290.40 us  |
| Query Iter 4096 Tables 8 Tags       | 163.04 us  | 163.04 us  |
| Query Iter 4096 Tables 8 comps      | 288.81 us  | 288.81 us  |
| Query Iter 65536 Tables 4 Tags      | 2.05 ms    | 2.05 ms    |
| Query Iter 65536 Tables 4 comps     | 4.89 ms    | 4.89 ms    |
| Query Iter 65536 Tables 8 Tags      | 2.05 ms    | 2.05 ms    |
| Query Iter 65536 Tables 8 comps     | 4.89 ms    | 4.89 ms    |
