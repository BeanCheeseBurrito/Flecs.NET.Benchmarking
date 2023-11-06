using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static unsafe partial class Benchmarks
{
    public static void GetMutRemoveCmd(string name, int idCount)
    {
        using World world = World.Create();
        using NativeArray<Entity> entities = Helpers.CreateIds(world, Helpers.EntityCount, 0, false);
        using NativeArray<Entity> ids = Helpers.CreateIds(world, idCount, 4, true);

        Benchmark.Run(name, Helpers.EntityCount, idCount * 2, () =>
        {
            world.DeferBegin();

            for (int e = 0; e < Helpers.EntityCount; e++)
                for (int i = 0; i < idCount; i++)
                    entities.Data[e].GetMutPtr(ids.Data[i]);

            world.DeferEnd();
            world.DeferBegin();

            for (int e = 0; e < Helpers.EntityCount; e++)
                for (int i = 0; i < idCount; i++)
                    entities.Data[e].Remove(ids.Data[i]);

            world.DeferEnd();
        });
    }
}
