namespace SpiceMustFlow
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            long startingYield = int.Parse(Console.ReadLine());
            bool isAbandoned = false;
            short daysCount = 0;
            long totalSpiceLeft = 0;
            while (!isAbandoned)
            {
                if (startingYield < 100)
                {
                    isAbandoned = true;
                    continue;
                }

                totalSpiceLeft += startingYield - 26;
                daysCount++;
                startingYield -= 10;
                if (startingYield < 100)
                {
                    isAbandoned = true;
                    totalSpiceLeft -= 26;
                    continue;
                }
            }

            Console.WriteLine($"{daysCount}");
            Console.WriteLine($"{totalSpiceLeft}");
        }
    }
}
