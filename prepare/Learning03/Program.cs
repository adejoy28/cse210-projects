using System;

class Program
{
    static void Main(string[] args)
    {
        // // Console.WriteLine(firstFraction);
        // Fraction secondFraction = new Fraction(6);
        // Fraction thirdFraction = new Fraction(6,7);

        Console.Write("Please input the numerator: ");
        int topValueInput = int.Parse(Console.ReadLine());
        Console.Write("Please input the denominator: ");
        int bottomValueInput = int.Parse(Console.ReadLine());

        Fraction thirdFraction = new Fraction();
        thirdFraction.SetTopValue(topValueInput);
        thirdFraction.SetBottomValue(bottomValueInput);

        Console.WriteLine(thirdFraction.GetFractionString());
        Console.WriteLine(thirdFraction.GetDecimalValue());

        
    }
}