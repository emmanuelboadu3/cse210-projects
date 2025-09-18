using System;

class Program
{
    static void Main(string[] args)
    {
        // Using Constructor 1: No parameters (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction f1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");

        // Using Constructor 2: One parameter (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Fraction f2: {f2.GetFractionString()} = {f2.GetDecimalValue()}");

        // Using Constructor 3: Two parameters (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction f3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");

        // Using Constructor 3: Two parameters (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction f4: {f4.GetFractionString()} = {f4.GetDecimalValue()}");
    }
}
