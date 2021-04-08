namespace PoundsToDollars
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            decimal poundsInput = decimal.Parse(Console.ReadLine());
            decimal pounds = 1.31m;
            decimal totalDollars = poundsInput * pounds;

            Console.WriteLine($"{totalDollars:f3}");
        }
    }
}
