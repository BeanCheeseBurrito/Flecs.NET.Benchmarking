using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void AddRemoveTagToComponents(string name, int componentCount)
    {
        using World world = World.Create();
        using NativeArray<Entity> entities = Helpers.CreateIds(world, Helpers.EntityCount, 0, false);
        using NativeArray<Entity> ids = Helpers.CreateIds(world, componentCount, 4, true);
        Entity tag = world.Entity();

        for (int e = 0; e < Helpers.EntityCount; e++)
            for (int i = 0; i < componentCount; i++)
                entities[e].Add(ids[i]);

        Benchmark.Run(name, Helpers.EntityCount, 2, () =>
        {
            for (int e = 0; e < Helpers.EntityCount; e++)
                entities.Data[e].Add(tag);

            for (int e = 0; e < Helpers.EntityCount; e++)
                entities.Data[e].Remove(tag);
        });
    }
}
