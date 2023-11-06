using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking.BenchmarkTests;

public static partial class Benchmarks
{
    public static void CreateDeleteTree(string name, int width, int depth)
    {
        using World world = World.Create();

        Benchmark.Run(name, width, 1, () =>
        {
            Entity root = world.Entity();
            Entity cur = root;

            for (int i = 0; i < depth; i++)
            {
                for (int w = 0; w < width - 1; w++)
                    cur = world.Entity().ChildOf(cur);

                cur = world.Entity().ChildOf(cur);
            }

            root.Destruct();
        });
    }
}
