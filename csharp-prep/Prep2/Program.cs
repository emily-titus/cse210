using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput);

        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        System.Console.WriteLine($"Your grade is: {letter}");

        if (userGrade >= 70)
        {
            System.Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            System.Console.WriteLine("Better luck next time!");
        }
    }
}