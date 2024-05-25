using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // Testing getters and setters:

        // fraction1.SetTop(5);
        // Console.WriteLine(fraction1.GetTop());
        // fraction1.SetBottom(10);
        // Console.WriteLine(fraction1.GetBottom());

        // fraction2.SetTop(15);
        // Console.WriteLine(fraction2.GetTop());
        // fraction2.SetBottom(20);
        // Console.WriteLine(fraction2.GetBottom());

        // fraction3.SetTop(25);
        // Console.WriteLine(fraction3.GetTop());
        // fraction3.SetBottom(30);
        // Console.WriteLine(fraction3.GetBottom());


    }
}