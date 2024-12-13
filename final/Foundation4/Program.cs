using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 12, 11), 25, 5),
            new Cycling(new DateTime(2024, 12, 12), 60, 15),
            new Swimming(new DateTime(2024, 12, 13), 45, 45)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}