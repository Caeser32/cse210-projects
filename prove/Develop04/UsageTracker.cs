using System;
using System.Collections.Generic;

public static class UsageTracker
{
    private static Dictionary<string, int> activityUsage = new Dictionary<string, int>();

    public static void Track(string activityName)
    {
        if (activityUsage.ContainsKey(activityName))
        {
            activityUsage[activityName]++;
        }
        else
        {
            activityUsage[activityName] = 1;
        }
    }

    public static void DisplayUsage()
    {
        Console.WriteLine("Activity Usage Statistics:");
        foreach (var entry in activityUsage)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
}
