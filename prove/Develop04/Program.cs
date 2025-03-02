using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();
        int input = 0;

        System.Console.WriteLine("Welcome to your Mindfulness Program!");
        while (input != 4)
        {
            System.Console.WriteLine("1. Breathing Activity \n2. Listing Activity\n3.Reflection Activity\n4. Quit");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                breathingActivity.Breathing();
            }
            else if (input == 2)
            {
                listingActivity.List();
            }
            else if (input == 3)
            {
                reflectionActivity.Reflection();
            }
        }
    }
}