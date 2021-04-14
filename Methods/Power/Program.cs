namespace Power
{
    using System;
    class Program
    {
        static double ReturnsPoweredNumber(double number, double pow)
        {
            double result = number;
            for (int i = 2; i <= pow; i++)
            {
                result *= number;
            }

            return result;
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Console.WriteLine(ReturnsPoweredNumber(number, pow));
        }
    }
}
