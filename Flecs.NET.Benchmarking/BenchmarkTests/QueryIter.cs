using Flecs.NET.Bindings;
using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void QueryIter(string name, int tableCount, int termCount, bool component)
    {
        using World world = World.Create();
        using NativeArray<Entity> termIds = Helpers.CreateIds(world, termCount, component ? 4 : 0, true);
        using NativeArray<Entity> tableIds = Helpers.CreateIds(world, tableCount, 0, true);

        for (int i = 0; i < tableCount; i++)
        {
            for (int j = 0; j < Helpers.QueryEntityCount / tableCount; j++)
            {
                Entity e = world.Entity();

                for (int c = 0; c < termCount; c++)
                    e.Add(termIds[c]);

                e.Add(tableIds[i]);
            }
        }

        FilterBuilder filterBuilder = world.FilterBuilder();

        for (int i = 0; i < termCount; i++)
            filterBuilder.With(termIds[i]).Self();

        using Query query = world.Query(filterBuilder);
        ulong result = default;

        Benchmark.Run(name, 1, 1, () =>
        {
            query.Iter((Iter it) =>
            {
                for (int i = 0; i < it.Count(); i ++)
                    result += it.Entity(i);
            });
        });
    }
}
