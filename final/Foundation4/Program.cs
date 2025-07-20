using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>()
        {
            new Swimming(new DateOnly(2025, 07, 19), 30, 25),
            new Running(new DateOnly(2025, 07, 19), 45, 2),
            new Cycling(new DateOnly(2025, 07, 19), 65, 5),
            new Running(new DateOnly(2025, 07, 18), 30, 1.5),
            new Cycling(new DateOnly(2025, 07, 18), 75, 10),
            new Swimming(new DateOnly(2025, 07, 17), 30, 18)
        };

        foreach (var activity in activities)
        {
            activity.GetSummary();
        }
    }
}