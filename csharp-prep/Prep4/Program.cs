using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        int userInput = 1;
        System.Console.Write("Enter a list of numbers, type 0 when finished. ");

        while (userInput != 0)
        {
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                number.Add(userInput);
            }
        }

        System.Console.WriteLine($"The sum is: {number.Sum()}");
        System.Console.WriteLine($"The average is: {number.Average()}");
        System.Console.WriteLine($"The largest number is: {number.Max()}");
    }
}