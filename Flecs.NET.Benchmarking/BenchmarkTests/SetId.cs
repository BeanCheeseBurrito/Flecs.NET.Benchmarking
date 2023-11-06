using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void SetId(string name, int idCount)
    {
        using World world = World.Create();
        using NativeArray<Entity> entities = Helpers.CreateIds(world, Helpers.EntityCount, 0, false);
        using NativeArray<Entity> ids = Helpers.CreateIds(world, idCount, 4, true);

        for (int e = 0; e < Helpers.EntityCount; e++)
            for (int i = 0; i < idCount; i++)
                entities.Data[e].Add(ids.Data[i]);

        Benchmark.Run(name, Helpers.EntityCount, idCount, () =>
        {
            int v = 0;

            for (int e = 0; e < Helpers.EntityCount; e++)
                for (int i = 0; i < idCount; i++)
                    entities.Data[e].SetPtr(ids.Data[i], 4, &v);
        });
    }
}
