using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void CreateDelete(string name, int idCount, bool component)
    {
        using World world = World.Create();
        using NativeArray<Entity> ids = Helpers.CreateIds(world, idCount, component ? 4 : 0, true);

        Benchmark.Run(name, Helpers.EntityCount, 2 + idCount, () =>
        {
            for (int e = 0; e < Helpers.EntityCount; e++)
            {
                Entity entity = world.Entity();

                for (int i = 0; i < idCount; i++)
                    entity.Add(ids[i]);

                entity.Destruct();
            }
        });
    }
}
