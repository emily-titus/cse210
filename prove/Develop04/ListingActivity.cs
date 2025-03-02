using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _promptList;

    public ListingActivity(string name = "Listing", string desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base(name, desc)
    {
        _promptList = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void List()
    {
        StartActivity();
        int inputs = 0;
        long duration = _duration - 7;
        Random rand = new Random();
        System.Console.WriteLine(_promptList.ElementAt(rand.Next(_promptList.Count)));
        System.Console.WriteLine("Think about it...");
        DisplayCountdown(3);
        System.Console.WriteLine("Write as many answers as you can think of...");
        Stopwatch stopwatch = new Stopwatch();
        duration -= 3;
        while (duration > 0)
        {
            stopwatch.Start();
            Console.ReadLine();
            inputs++;
            stopwatch.Stop();
            duration -= stopwatch.ElapsedMilliseconds / 1000;
            if (stopwatch.ElapsedMilliseconds > 1000)
            {
                stopwatch.Reset();
            }
        }
        System.Console.WriteLine($"You listed {inputs} things");
        EndActivity();
    }
}