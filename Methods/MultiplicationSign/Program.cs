namespace MultiplicationSign
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long firstInput = long.Parse(Console.ReadLine());
            long secondInput = long.Parse(Console.ReadLine());
            long thirdInput = long.Parse(Console.ReadLine());
            PrintsTypeOfMultiplication(firstInput, secondInput, thirdInput);
        }

        static void PrintsTypeOfMultiplication(long firstInput, long secondInput, long thirdInput)
        {
            int negativeCount = 0;
            if (firstInput < 0)
            {
                negativeCount++;
            }

            if (secondInput < 0)
            {
                negativeCount++;
            }

            if (thirdInput < 0)
            {
                negativeCount++;
            }

            if (firstInput == 0 || secondInput == 0 || thirdInput == 0)
            {
                Console.WriteLine("zero");
            }
            else if ((negativeCount != 0 && negativeCount % 2 == 0) || (firstInput > 0 && secondInput > 0 && thirdInput > 0))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
