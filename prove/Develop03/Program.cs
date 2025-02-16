using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string verse = File.ReadAllText("scriptures.txt");
        string[] verses = verse.Split(">");
        List<Word> words = new List<Word>();
        List<Word> words2 = new List<Word>();
        for (int i = 0; i < verses[0].Split("|").Length; i++)
        {
            Word word = new Word(verses[0].Split("|")[i]);
            words.Add(word);
        }
        for (int i = 0; i < verses[1].Split("|").Length; i++)
        {
            Word word = new Word(verses[1].Split("|")[i]);
            words2.Add(word);
        }
        Reference reference1 = new Reference("D&C", 18, 5);
        Scripture scripture = new Scripture(reference1, words);
        Random rand = new Random();
        string input = "";
        bool allhiden = false;
        while (!allhiden && input != "quit")
        {
            Console.Clear();
            allhiden = true;
            System.Console.WriteLine(scripture.GetFormat());
            foreach (Word word in scripture.GetWords())
            {
                if (!word.GetHidden())
                {
                    allhiden = false;
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Please prese enter to hide more words, or type quit to leave!");
            input = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                int wordnumber = rand.Next(0, words.Count);
                scripture.GetWords()[wordnumber].Hide();
            }
        }


    }
}

//D&C 18: 5-6 is what's in the text file 