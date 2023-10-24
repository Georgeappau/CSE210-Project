using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(DateTime.Now, 30, 3.0)); // 3 miles in 30 minutes
        activities.Add(new Cycling(DateTime.Now, 45, 15.0)); // 15 mph in 45 minutes
        activities.Add(new Swimming(DateTime.Now, 60, 40)); // 2.0 km (40 laps) in 60 minutes

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}