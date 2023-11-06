using System;
using Flecs.NET.Bindings;
using Flecs.NET.Collections;
using Flecs.NET.Core;

namespace Flecs.NET.Benchmarking;

public static unsafe class Helpers
{
    public const int EntityCount = 1000;
    public const int QueryEntityCount = 65536;

    public static void PrintHeader()
    {
        Console.WriteLine($"| {"Benchmark", -35} | {"Total", -10} | {"Average", -10} |");
        Console.WriteLine($"| {new string('-', 35)} | {new string('-', 10)} | {new string('-', 10)} |");
    }

    public static string TimeString(double time)
    {
        const double ns = 1 / 1_000_000_000d;
        const double us = 1 / 1_000_000d;
        const double ms = 1 / 1_000d;

        string str = time switch
        {
            < us => $"{time / ns : 0.00} ns",
            < ms => $"{time / us : 0.00} us",
            < 1 => $"{time / ms : 0.00} ms",
            _ => $"{time : 0.00} s"
        };

        return str.Trim();
    }

    public static NativeArray<Entity> CreateIds(World world, int count, int size, bool useLowId)
    {
        NativeArray<Entity> ids = new(count);

        for (int i = 0; i < count; i++)
        {
            ids[i] = new Entity(world, useLowId ? Native.ecs_new_low_id(world) : Native.ecs_new_id(world));

            if (size != 0)
                ids[i].Set(new Native.EcsComponent { size = size, alignment = 4});
        }

        return ids;
    }
}
