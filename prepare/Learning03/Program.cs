using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        System.Console.WriteLine(fraction1.GetFractionString());
        System.Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        System.Console.WriteLine(fraction2.GetFractionString());
        System.Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(2, 4);
        System.Console.WriteLine(fraction3.GetFractionString());
        System.Console.WriteLine(fraction3.GetDecimalValue());
    }
}