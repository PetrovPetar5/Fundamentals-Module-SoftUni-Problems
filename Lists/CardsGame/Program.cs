namespace CardsGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool secondIsZero = false;
            for (int i = 0; i < firstDeck.Count; i++)
            {
                if (secondDeck.Count == 0)
                {
                    secondIsZero = true;
                    break;
                }

                if (firstDeck[i] > secondDeck[i])
                {
                    int temp = firstDeck[i];
                    firstDeck.RemoveAt(0);
                    firstDeck.Add(temp);
                    firstDeck.Add(secondDeck[i]);
                    secondDeck.RemoveAt(0);
                }
                else if (firstDeck[i] == secondDeck[i])
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else
                {
                    int temp = secondDeck[i];
                    secondDeck.RemoveAt(0);
                    secondDeck.Add(temp);
                    secondDeck.Add(firstDeck[i]);
                    firstDeck.RemoveAt(0);
                }

                i--;
            }

            if (secondIsZero)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }
    }
}
