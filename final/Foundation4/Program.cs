using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 12, 1), 30, 3.0),
            new Cycling(new DateTime(2023, 12, 2), 45, 20.0),
            new Swimming(new DateTime(2023, 12, 3), 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
