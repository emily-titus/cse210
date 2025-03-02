public class Activity
{
    private string _name;
    private string _desc;
    protected int _duration;

    public Activity()
    {

    }
    public Activity(string name, string desc)
    {
        _name = name;
        _desc = desc;
    }

    public void StartActivity()
    {
        System.Console.WriteLine($"Welcome to the {_name} Activity");
        System.Console.WriteLine($"{_desc}");
        System.Console.Write("How long do you want the activity to last? ");
        _duration = int.Parse(Console.ReadLine());
        // sets a minimum duration 
        if (_duration < 15)
        {
            _duration = 15;
        }
        System.Console.WriteLine("Get ready to begin... ");
        DisplayAnimation(2);
    }


    public void DisplayCountdown(int seconds)
    {
        while (seconds != 0)
        {
            System.Console.WriteLine(seconds);
            Thread.Sleep(1000);
            seconds--;
        }
    }

    public void DisplayAnimation(double seconds)
    {
        while (seconds > 0)
        {
            // made animation cooler
            System.Console.Write("|...");
            Thread.Sleep(250);
            System.Console.Write("\b \b \b \b \b");
            System.Console.Write("/");
            Thread.Sleep(250);
            System.Console.Write("\b \b");
            System.Console.Write("-");
            Thread.Sleep(250);
            System.Console.Write("\b \b");
            System.Console.Write("\\");
            Thread.Sleep(250);
            System.Console.Write("\b \b");
            seconds--;
        }
    }
    public void EndActivity()
    {
        System.Console.WriteLine("Well done!");
        DisplayAnimation(5);
        System.Console.WriteLine($"You completed the {_name} activity!");
        System.Console.WriteLine($"It took {_duration} seconds");
        System.Console.WriteLine(":)");
    }
}