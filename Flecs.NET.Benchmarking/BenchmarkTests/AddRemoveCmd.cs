using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void AddRemoveCmd(string name, int idCount, bool component)
    {
        using World world = World.Create();
        using NativeArray<Entity> entities = Helpers.CreateIds(world, Helpers.EntityCount, 0, false);
        using NativeArray<Entity> ids = Helpers.CreateIds(world, idCount, component ? 4 : 0, true);

        Benchmark.Run(name, Helpers.EntityCount, idCount * 2, () =>
        {
            world.DeferBegin();

            for (int e = 0; e < Helpers.EntityCount; e++)
                for (int i = 0; i < idCount; i++)
                    entities.Data[e].Add(ids.Data[i]);

            world.DeferEnd();
            world.DeferBegin();

            for (int e = 0; e < Helpers.EntityCount; e++)
                for (int i = 0; i < idCount; i++)
                    entities.Data[e].Remove(ids.Data[i]);

            world.DeferEnd();
        });
    }
}
