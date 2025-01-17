using System;

class Program
{
    static void Main(string[] args)
    {

        Random rand = new Random();
        int magicNumber = rand.Next(101);
        int guess = 0;
        string response = "yes";

        while (response == "yes")
        {
            System.Console.Write("What is the magic number? ");
            magicNumber = rand.Next(101);
            guess = 0;

            while (guess != magicNumber)
            {
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                    System.Console.WriteLine("Higher");
                }
                if (guess > magicNumber)
                {
                    System.Console.WriteLine("Lower");
                }

            }
            System.Console.WriteLine("You guessed it!");
            System.Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }

    }


}