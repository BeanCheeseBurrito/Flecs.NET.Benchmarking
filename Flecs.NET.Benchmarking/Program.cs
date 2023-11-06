using Flecs.NET.Benchmarking;
using Flecs.NET.Benchmarking.BenchmarkTests;

Helpers.PrintHeader();

Benchmarks.HasEmptyEntity("Has Empty Entity");
Benchmarks.HasIdNotFound("Has Id Not Found");
Benchmarks.HasId("Has 1 Id", 1);
Benchmarks.HasId("Has 16 Ids", 16);

Benchmarks.GetEmptyEntity("Get Empty Entity");
Benchmarks.GetIdNotFound("Get Id Not Found");
Benchmarks.GetId("Get 1 Id", 1);
Benchmarks.GetId("Get 16 Ids", 16);
Benchmarks.GetPair("Get Pair", 1);
Benchmarks.GetPair("Get Pair 16 Targets", 16);

Benchmarks.GetInherited("Get Inherited Depth 1", 1);
Benchmarks.GetInherited("Get Inherited Depth 2", 2);
Benchmarks.GetInherited("Get Inherited Depth 16", 16);
Benchmarks.GetInherited("Get Inherited Depth 32", 32);

Benchmarks.GetMutId("Get Mut 1 Id", 1);
Benchmarks.GetMutId("Get Mut 16 Ids", 16);

Benchmarks.SetId("Set 1 Id", 1);
Benchmarks.SetId("Set 16 Ids", 16);

Benchmarks.GetMutRemove("Get Mut Remove 1 Id", 1);
Benchmarks.GetMutRemove("Get Mut Remove 16 Ids", 16);
Benchmarks.GetMutRemove("Get Mut Remove 32 Ids", 32);

Benchmarks.AddRemove("Add Remove 1 Tag", 1, false);
Benchmarks.AddRemove("Add Remove 2 Tags", 2, false);
Benchmarks.AddRemove("Add Remove 16 Tags", 16, false);
Benchmarks.AddRemove("Add Remove 32 Tags", 32, false);
Benchmarks.AddRemove("Add Remove 1 Component", 1, true);
Benchmarks.AddRemove("Add Remove 2 Components", 2, true);
Benchmarks.AddRemove("Add Remove 16 Components", 16, true);
Benchmarks.AddRemove("Add Remove 32 Components", 32, true);

Benchmarks.AddExisting("Add Existing 1 Tag", 1, false);
Benchmarks.AddExisting("Add Existing 16 Tags", 16, false);
Benchmarks.AddExisting("Add Existing 1 Component", 1, true);
Benchmarks.AddExisting("Add Existing 16 Components", 16, true);

Benchmarks.AddRemoveTagToComponents("Add Remove Tag To 1 Component", 1);
Benchmarks.AddRemoveTagToComponents("Add Remove Tag To 4 Components", 4);
Benchmarks.AddRemoveTagToComponents("Add Remove Tag To 8 Components", 8);
Benchmarks.AddRemoveTagToComponents("Add Remove Tag To 16 Components", 16);
Benchmarks.AddRemoveTagToComponents("Add Remove Tag To 64 Components", 64);

Benchmarks.AddRemoveOverride("Add Remove Override 1", 1);
Benchmarks.AddRemoveOverride("Add Remove Override 2", 2);
Benchmarks.AddRemoveOverride("Add Remove Override 4", 4);
Benchmarks.AddRemoveOverride("Add Remove Override 16", 16);

Benchmarks.AddRemoveCmd("Add Remove Cmd 1 Tag", 1, false);
Benchmarks.AddRemoveCmd("Add Remove Cmd 2 Tags", 2, false);
Benchmarks.AddRemoveCmd("Add Remove Cmd 16 Tags", 16, false);
Benchmarks.AddRemoveCmd("Add Remove Cmd 32 Tags", 32, false);
Benchmarks.AddRemoveCmd("Add Remove Cmd 1 Components", 1, true);
Benchmarks.AddRemoveCmd("Add Remove Cmd 2 Components", 2, true);
Benchmarks.AddRemoveCmd("Add Remove Cmd 16 Components", 16, true);
Benchmarks.AddRemoveCmd("Add Remove Cmd 32 Components", 32, true);

Benchmarks.GetMutCmd("Get Mut Cmd 1", 1);
Benchmarks.GetMutCmd("Get Mut Cmd 2", 2);
Benchmarks.GetMutCmd("Get Mut Cmd 16", 16);
Benchmarks.GetMutCmd("Get Mut Cmd 32", 32);

Benchmarks.SetCmd("Set Cmd 1", 1);
Benchmarks.SetCmd("Set Cmd 2", 2);
Benchmarks.SetCmd("Set Cmd 16", 16);
Benchmarks.SetCmd("Set Cmd 32", 32);

Benchmarks.GetMutRemoveCmd("Get Mut Remove Cmd 1", 1);
Benchmarks.GetMutRemoveCmd("Get Mut Remove Cmd 2", 2);
Benchmarks.GetMutRemoveCmd("Get Mut Remove Cmd 16", 16);
Benchmarks.GetMutRemoveCmd("Get Mut Remove Cmd 32", 32);

Benchmarks.CreateDelete("Create Delete empty", 0, false);
Benchmarks.CreateDelete("Create Delete 1 Tag", 1, false);
Benchmarks.CreateDelete("Create Delete 2 Tags", 2, false);
Benchmarks.CreateDelete("Create Delete 16 Tags", 16, false);
Benchmarks.CreateDelete("Create Delete 1 Component", 1, true);
Benchmarks.CreateDelete("Create Delete 2 Components", 2, true);
Benchmarks.CreateDelete("Create Delete 16 Components", 16, true);

Benchmarks.CreateDeleteTree("Create Delete Tree W1 D1", 1, 1);
Benchmarks.CreateDeleteTree("Create Delete Tree W1 D10", 1, 10);
Benchmarks.CreateDeleteTree("Create Delete Tree W1 D100", 1, 100);
Benchmarks.CreateDeleteTree("Create Delete Tree W1 D1000", 1, 1000);

Benchmarks.CreateDeleteTree("Create Delete Tree W10 D1", 10, 1);
Benchmarks.CreateDeleteTree("Create Delete Tree W10 D10", 10, 10);
Benchmarks.CreateDeleteTree("Create Delete Tree W10 D100", 10, 100);
Benchmarks.CreateDeleteTree("Create Delete Tree W10 D1000", 10, 1000);

Benchmarks.CreateDeleteTree("Create Delete Tree W100 D1", 100, 1);
Benchmarks.CreateDeleteTree("Create Delete Tree W100 D10", 100, 10);
Benchmarks.CreateDeleteTree("Create Delete Tree W100 D100", 100, 100);
Benchmarks.CreateDeleteTree("Create Delete Tree W100 D1000", 100, 1000);

Benchmarks.CreateDeleteTree("Create Delete Tree W1000 D1", 1000, 1);
Benchmarks.CreateDeleteTree("Create Delete Tree W1000 D10", 1000, 10);
Benchmarks.CreateDeleteTree("Create Delete Tree W1000 D100", 1000, 100);
Benchmarks.CreateDeleteTree("Create Delete Tree W1000 D1000", 1000, 1000);

Benchmarks.QueryIter("Query Iter 1 Table 1 Tag", 1, 1, false);
Benchmarks.QueryIter("Query Iter 2 Tables 1 Tag", 2, 1, false);
Benchmarks.QueryIter("Query Iter 4 Tables 1 Tag", 4, 1, false);
Benchmarks.QueryIter("Query Iter 8 Tables 1 Tag", 8, 1, false);
Benchmarks.QueryIter("Query Iter 16 Tables 1 Tag", 16, 1, false);
Benchmarks.QueryIter("Query Iter 32 Tables 1 Tag", 32, 1, false);
Benchmarks.QueryIter("Query Iter 64 Tables 1 Tag", 64, 1, false);
Benchmarks.QueryIter("Query Iter 128 Tables 1 Tag", 128, 1, false);
Benchmarks.QueryIter("Query Iter 256 Tables 1 Tag", 256, 1, false);
Benchmarks.QueryIter("Query Iter 512 Tables 1 Tag", 512, 1, false);
Benchmarks.QueryIter("Query Iter 1024 Tables 1 Tag", 1024, 1, false);
Benchmarks.QueryIter("Query Iter 4096 Tables 1 Tag", 4096, 1, false);
Benchmarks.QueryIter("Query Iter 4096 Tables 4 Tags", 4096, 8, false);
Benchmarks.QueryIter("Query Iter 4096 Tables 4 comps", 4096, 8, true);
Benchmarks.QueryIter("Query Iter 4096 Tables 8 Tags", 4096, 8, false);
Benchmarks.QueryIter("Query Iter 4096 Tables 8 comps", 4096, 8, true);
Benchmarks.QueryIter("Query Iter 65536 Tables 4 Tags", 65536, 8, false);
Benchmarks.QueryIter("Query Iter 65536 Tables 4 comps", 65536, 8, true);
Benchmarks.QueryIter("Query Iter 65536 Tables 8 Tags", 65536, 8, false);
Benchmarks.QueryIter("Query Iter 65536 Tables 8 comps", 65536, 8, true);
