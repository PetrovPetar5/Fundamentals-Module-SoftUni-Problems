namespace SpecialNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int inputsToRead = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputsToRead; i++)
            {
                int curNumber = i;
                int total = 0;
                while (curNumber != 0)
                {
                    int curDigit = curNumber % 10;
                    curNumber /= 10;
                    total += curDigit;
                }

                bool isSpecial = total == 5 || total == 7 || total == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
