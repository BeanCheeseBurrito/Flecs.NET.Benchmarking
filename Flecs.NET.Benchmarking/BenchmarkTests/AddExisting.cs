using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void AddExisting(string name, int idCount, bool component)
    {
        using World world = World.Create();
        using NativeArray<Entity> entities = Helpers.CreateIds(world, Helpers.EntityCount, 0, false);
        using NativeArray<Entity> ids = Helpers.CreateIds(world, idCount, component ? 4 : 0, true);

        for (int e = 0; e < Helpers.EntityCount; e++)
            entities[e].Add(ids[0]);

        Benchmark.Run(name, Helpers.EntityCount, idCount, () =>
        {
            for (int e = 0; e < Helpers.EntityCount; e++)
                for (int i = 0; i < idCount; i++)
                    entities.Data[e].Add(ids.Data[i]);
        });
    }
}
