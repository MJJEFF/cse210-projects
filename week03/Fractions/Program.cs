using System;

class Program
{
    static void Main(string[] args)
    {
        // Constructor tests
        Fraction f1 = new Fraction();        // 1/1
        Fraction f2 = new Fraction(5);       // 5/1
        Fraction f3 = new Fraction(6, 7);    // 6/7

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Getter/setter tests
        Fraction f4 = new Fraction();
        f4.SetTop(3);
        f4.SetBottom(4);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Fraction f5 = new Fraction();
        f5.SetTop(1);
        f5.SetBottom(3);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
    }
}