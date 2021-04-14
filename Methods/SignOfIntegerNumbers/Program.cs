namespace SignOfIntegerNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            PrintsNumberSign(inputNumber);
        }
        static void PrintsNumberSign(int inputNumber)
        {
            if (inputNumber > 0)
            {
                Console.WriteLine($"The number {inputNumber} is positive.");
            }
            else if (inputNumber == 0)
            {
                Console.WriteLine($"The number {inputNumber} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {inputNumber} is negative.");
            }
        }
    }
}
