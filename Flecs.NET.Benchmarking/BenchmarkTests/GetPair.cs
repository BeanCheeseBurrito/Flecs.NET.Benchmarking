using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void GetPair(string name, int targetCount)
    {
        using World world = World.Create();
        using NativeArray<Entity> entities = Helpers.CreateIds(world, Helpers.EntityCount, 0, false);
        using NativeArray<Entity> rel = Helpers.CreateIds(world, 1, 4, true);
        using NativeArray<Entity> tgt = Helpers.CreateIds(world, targetCount, 0, false);

        for (int e = 0; e < Helpers.EntityCount; e++)
            for (int i = 0; i < targetCount; i++)
                entities.Data[e].Add(rel.Data[0], tgt.Data[i]);

        Benchmark.Run(name, Helpers.EntityCount, targetCount, () =>
        {
            for (int e = 0; e < Helpers.EntityCount; e++)
                for (int i = 0; i < targetCount; i++)
                    entities.Data[e].GetPtr(rel.Data[0], tgt.Data[i]);
        });
    }
}
