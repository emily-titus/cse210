using System;

class Program
{

    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        System.Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        System.Console.Write("What is your favorite number? ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int favNumber)
    {
        favNumber = favNumber * favNumber;
        return favNumber;
    }

    static void DisplayResults(string userName, int favNumber)
    {
        System.Console.WriteLine($"{userName}, the square of your number is {favNumber}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int sqNumber = SquareNumber(favNumber);
        DisplayResults(userName, sqNumber);
    }
}