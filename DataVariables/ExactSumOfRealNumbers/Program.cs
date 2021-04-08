namespace ExactSumOfRealNumbers
{
    using System;
    class Program
    {
        static void Main()
        {
            int numbersToReadCount = int.Parse(Console.ReadLine());
            decimal totalSum = 0;

            for (int i = 1; i <= numbersToReadCount; i++)
            {
                decimal curNumber = decimal.Parse(Console.ReadLine());
                totalSum += curNumber;
            }

            Console.WriteLine($"{totalSum}");
        }
    }
}
