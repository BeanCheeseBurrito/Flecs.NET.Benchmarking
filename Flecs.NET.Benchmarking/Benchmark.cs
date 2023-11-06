using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Flecs.NET.Benchmarking;

public struct Benchmark
{
    public string Name;

    public int Entities;
    public int Operations;

    public long LastTimeStamp;
    public long TimeLimit;
    public long TimeElapsed;

    public int TotalRuns;

    public Benchmark(string name, double timeLimit = 1, int entities = 1, int operations = 1)
    {
        Name = name;
        Entities = entities;
        Operations = operations;
        TimeLimit = (long)(timeLimit * Stopwatch.Frequency);

        LastTimeStamp = Stopwatch.GetTimestamp();
    }

    public static void Run(string name, int entities, int operations, Action action)
    {
        RuntimeHelpers.PrepareDelegate(action);
        Benchmark benchmark = new(name, .5f, entities, operations);
        do
        {
            action();
        } while (benchmark.RunNext());
        benchmark.PrintResults();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool RunNext()
    {
        long newTimeStamp = Stopwatch.GetTimestamp();
        TimeElapsed += newTimeStamp - LastTimeStamp;
        TotalRuns++;

        bool shouldContinue = TimeElapsed < TimeLimit;
        LastTimeStamp = Stopwatch.GetTimestamp();

        return shouldContinue;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void PrintResults()
    {
        double totalTime = (double)TimeElapsed / Stopwatch.Frequency / TotalRuns / Entities;
        double averageTime = totalTime/ Operations;

        Console.WriteLine($"| {Name, -35} | {Helpers.TimeString(totalTime), -10} | {Helpers.TimeString(averageTime), -10} |");
    }
}
