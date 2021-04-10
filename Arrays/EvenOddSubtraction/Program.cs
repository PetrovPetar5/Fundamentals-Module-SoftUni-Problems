namespace EvenOddSubtraction
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int number = int.Parse(inputArray[i]);

                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            Console.WriteLine($"{evenSum - oddSum}");
        }
    }
}
