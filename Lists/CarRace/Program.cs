namespace CarRace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int timesToLoop = numbers.Count / 2;
            double firstRacerTime = 0;
            double secondRacerTime = 0;
            for (int i = 0; i < timesToLoop; i++)
            {
                if (numbers[i] == 0)
                {
                    firstRacerTime *= 0.80;
                }
                else
                {
                    firstRacerTime += numbers[i];
                }
            }

            for (int i = numbers.Count - 1; i > timesToLoop; i--)
            {
                if (numbers[i] == 0)
                {
                    secondRacerTime *= 0.80;
                }
                else
                {
                    secondRacerTime += numbers[i];
                }
            }

            if (secondRacerTime < firstRacerTime)
            {
                Console.WriteLine($"The winner is right with total time: {secondRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {firstRacerTime}");
            }
        }
    }
}
