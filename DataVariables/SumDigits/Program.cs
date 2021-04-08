namespace SumDigits
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int totalInputSum = 0;
            while (numberInput > 0)
            {
                int curDigit = numberInput % 10;
                numberInput /= 10;
                totalInputSum += curDigit;
            }

            Console.WriteLine(totalInputSum);
        }
    }
}
