using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5);
        System.Console.WriteLine($"Color: {square.GetColor()}, Area: {square.GetArea()}");
    }
}