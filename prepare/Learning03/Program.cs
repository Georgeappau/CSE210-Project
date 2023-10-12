using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,4);
        Fraction fraction4 = new Fraction(1,3);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // fraction2.SetTopNum(6);
        // fraction3.SetTopNum(6);
        // fraction3.SetBottomNum(7);

        // Console.WriteLine($"Fraction 1: {fraction1.GetTopNumber()}/ {fraction1.GetBottomNum()} ");
        // Console.WriteLine($"Fraction 2: {fraction2.GetTopNumber()}/ {fraction2.GetBottomNum()} ");
        // Console.WriteLine($"Fraction 3: {fraction3.GetTopNumber()}/ {fraction3.GetBottomNum()} ");
    }
    //     {
    //     Fraction fraction1 = new Fraction();     // Initializes to 1/1
    //     Fraction fraction2 = new Fraction(6);    // Initializes to 6/1
    //     Fraction fraction3 = new Fraction(6, 7); // Initializes to 6/7

    //     // Output the fractions using the properties
    //     Console.WriteLine("Fraction 1: " + fraction1.Numerator + "/" + fraction1.Denominator);
    //     Console.WriteLine("Fraction 2: " + fraction2.Numerator + "/" + fraction2.Denominator);
    //     Console.WriteLine("Fraction 3: " + fraction3.Numerator + "/" + fraction3.Denominator);
    // }
}