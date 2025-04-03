using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(3, "4/2/25", 30, "Running");
        Bicycle bicycle = new Bicycle(600, "10/2/20205", 2, "Bicycle");
        Swimming swimming = new Swimming(5, "1/3/2024", 30, "Swimming");
        activities.Add(running);
        activities.Add(bicycle);
        activities.Add(swimming);
        foreach (Activity activity in activities)
        {
            System.Console.WriteLine(activity.GetSummary());
        }
    }
}