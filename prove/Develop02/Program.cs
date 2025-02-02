using System;

// Exceeded requirements by saving with a Json file 

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int userInput = 10000;

        Journal journal = new Journal(new List<Entry>());

        while (userInput != 5)
        {
            userInput = int.Parse(menu.Display());

            if (userInput == 1)
            {
                journal.AddEntry();
            }
            if (userInput == 2)
            {
                System.Console.WriteLine(journal.GetDisplay());
            }
            if (userInput == 3)
            {
                System.Console.WriteLine("What is the file name you would like to load? ");
                System.Console.WriteLine(">");
                string fileName = Console.ReadLine();
                if (menu.Load(fileName) != null)
                {
                    journal = menu.Load(fileName);
                }
            }
            if (userInput == 4)
            {
                System.Console.WriteLine("What is the name of the file you want to save? ");
                System.Console.WriteLine(">");
                string fileSave = Console.ReadLine();
                menu.Save(fileSave, journal);
            }
        }
        System.Console.WriteLine("Thank you for Journaling, see you tomorrow!");
    }
}