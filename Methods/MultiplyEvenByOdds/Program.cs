namespace MultiplyEvenByOdds
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            string number = input.ToString();
            int evenSum = GetsEvenDigits(number);
            int oddSum = GetsOddDigits(number);
            int result = GivesMultipliedOddEven(evenSum, oddSum);
            Console.WriteLine(result);
        }

        static int GetsEvenDigits(string number)
        {
            int evenSum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int curDigit = int.Parse(number[i].ToString());
                if (curDigit % 2 == 0)
                {
                    evenSum += curDigit;
                }
            }

            return evenSum;
        }
        static int GetsOddDigits(string number)
        {
            int oddSum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int curDigit = int.Parse(number[i].ToString());
                if (curDigit % 2 != 0)
                {
                    oddSum += curDigit;
                }
            }

            return oddSum;
        }

        static int GivesMultipliedOddEven(int evenSum, int oddSum)
        {
            int result = evenSum * oddSum;
            return result;
        }
    }
}
