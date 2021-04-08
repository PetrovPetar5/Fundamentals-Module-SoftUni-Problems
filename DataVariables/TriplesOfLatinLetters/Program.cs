namespace TriplesOfLatinLetters
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNumber; i++)
            {
                for (int g = 0; g < inputNumber; g++)
                {
                    for (int k = 0; k < inputNumber; k++)
                    {
                        char firstSymbol = (char)('a' + i);
                        char secondSymbol = (char)('a' + g);
                        char ThirdSymbol = (char)('a' + k);
                        Console.WriteLine($"{firstSymbol}{secondSymbol}{ThirdSymbol}");
                    }
                }
            }
        }
    }
}
