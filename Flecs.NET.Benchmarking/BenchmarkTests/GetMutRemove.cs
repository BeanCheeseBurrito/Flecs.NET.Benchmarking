using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void GetMutRemove(string name, int idCount)
    {
        using World world = World.Create();
        using NativeArray<Entity> entities = Helpers.CreateIds(world, Helpers.EntityCount, 0, false);
        using NativeArray<Entity> ids = Helpers.CreateIds(world, idCount, 4, true);

        Benchmark.Run(name, Helpers.EntityCount, idCount * 2, () =>
        {
            for (int e = 0; e < Helpers.EntityCount; e++)
            {
                for (int i = 0; i < idCount; i++)
                    entities.Data[e].GetMutPtr(ids.Data[i]);

                for (int i = 0; i < idCount; i ++)
                    entities.Data[e].Remove(ids.Data[i]);
            }
        });
    }
}
