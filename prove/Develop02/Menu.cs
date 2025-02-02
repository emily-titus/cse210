using System;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;

public class Menu
{
    public string Display()
    {
        System.Console.WriteLine("Welcome to your Journal!");
        System.Console.WriteLine("Please select one of the following choices:");
        System.Console.WriteLine("1. Write");
        System.Console.WriteLine("2. Display");
        System.Console.WriteLine("3. Load");
        System.Console.WriteLine("4. Save");
        System.Console.WriteLine("5. Quit");
        System.Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
        return choice;
    }

    public Journal Load(string fileName)
    {
        if (!File.Exists(fileName))
        {
            System.Console.WriteLine("File does not exist");
            return null;
        }

        string jsoninfo = File.ReadAllText(fileName);
        Journal journal = JsonSerializer.Deserialize<Journal>(jsoninfo);
        System.Console.WriteLine("Journal Loaded");
        return journal;
    }

    public void Save(string fileName, Journal journal)
    {
        string jsoninfo = JsonSerializer.Serialize(journal, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, jsoninfo);
        System.Console.WriteLine("Journal saved ");
    }

}