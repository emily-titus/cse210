using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text.Json.Serialization;

public class Journal
{
    [JsonIgnore]
    public List<string> _prompts { get; private set; }
    [JsonInclude]
    public List<Entry> Entries { get; set; }
    public Journal()
    {
        Entries = new List<Entry>();
        _prompts = new List<string>
        {
            "What was the prettiest color I saw today? ",
            "If I had one thing I could repeate from today, what would it be? ",
            "What made me the happiest today? ","What was the tastiest thing I ate today? ",
            "What small miracles did I notice in my life today? ",
            "What was the funnest thing you did today? ","What made you laugh today? "
        };
    }

    public Journal(List<Entry> entries) : this()
    {
        Entries = entries;
    }
    public string GetDisplay()
    {
        string display = "";

        foreach (Entry entry in Entries)
        {
            display += entry.GetDisplay();
        }
        return display;
    }

    public void AddEntry()
    {
        Random rand = new Random();
        string dateofentry = DateTime.Now.ToString("M/d/yyyy");
        string prompt = _prompts[rand.Next(0, 5)];

        System.Console.WriteLine(">>>");
        System.Console.WriteLine(prompt);
        System.Console.Write(">");
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, dateofentry, response);
        this.Entries.Add(entry);
    }

}