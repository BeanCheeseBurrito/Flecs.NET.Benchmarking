using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void HasEmptyEntity(string name)
    {
        using World world = World.Create();
        using NativeArray<Entity> entities = Helpers.CreateIds(world, Helpers.EntityCount, 0, false);
        using NativeArray<Entity> ids = Helpers.CreateIds(world, 1, 0, true);

        Benchmark.Run(name, Helpers.EntityCount, 1, () =>
        {
            for (int e = 0; e < Helpers.EntityCount; e++)
                entities.Data[e].Has(ids.Data[0]);
        });
    }
}
