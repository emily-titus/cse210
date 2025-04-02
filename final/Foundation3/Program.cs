using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Turtle st", "Puyallup", "WA", "USA");
        Lecture lecture = new Lecture("Billy Bob Joe", 500, "How to be a good person", "A high energy presentation that will make you question everything", "4/15/2025", "1:30pm", address, "Lecture");
        System.Console.WriteLine(lecture.StandardDetail());
        System.Console.WriteLine();
        System.Console.WriteLine(lecture.FullDetail());
        System.Console.WriteLine();
        System.Console.WriteLine(lecture.ShortDescription());
        System.Console.WriteLine();
        Reception reception = new Reception("flowerfield@gmail.com", "Garden Party", "A lovely afternoon filled with flowers and treats", "5/19/2025", "11:00am - 1:00pm", address, "Reception");
        System.Console.WriteLine(reception.StandardDetail());
        System.Console.WriteLine();
        System.Console.WriteLine(reception.FullDetail());
        System.Console.WriteLine();
        System.Console.WriteLine(reception.ShortDescription());
        System.Console.WriteLine();
        Outdoor outdoor = new Outdoor("Sunny", "Water Fight", "Come have fun in the sun! We've got water ballons, water guns, buckets, sprinklers, and more!", "7/5/2025", "2:00pm", address, "Outdoor");
        System.Console.WriteLine(outdoor.StandardDetail());
        System.Console.WriteLine();
        System.Console.WriteLine(outdoor.FullDetail());
        System.Console.WriteLine();
        System.Console.WriteLine(outdoor.ShortDescription());
    }
}