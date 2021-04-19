namespace HouseParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int commandsToFollow = int.Parse(Console.ReadLine());
            List<string> partyGoingGuests = new List<string>();
            for (int i = 0; i < commandsToFollow; i++)
            {
                List<string> curCommandElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                partyGoingGuests = MakesAListOfGuests(curCommandElements, partyGoingGuests);
            }

            PrintsAllPartyGuests(partyGoingGuests);
        }

        static List<string> MakesAListOfGuests(List<string> curCommandElements, List<string> partyGoingGuests)
        {
            if (curCommandElements[2] == "going!")
            {
                if (partyGoingGuests.Contains(curCommandElements[0]))
                {
                    Console.WriteLine($"{curCommandElements[0]} is already in the list!");
                }
                else
                {
                    partyGoingGuests.Add(curCommandElements[0]);
                }
            }
            else if (curCommandElements[2] == "not")
            {
                if (partyGoingGuests.Contains(curCommandElements[0]))
                {
                    partyGoingGuests.Remove(curCommandElements[0]);
                }
                else
                {
                    Console.WriteLine($"{curCommandElements[0]} is not in the list!");
                }
            }

            return partyGoingGuests;
        }

        static void PrintsAllPartyGuests(List<string> partyGoingGuests)
        {
            for (int i = 0; i < partyGoingGuests.Count; i++)
            {
                Console.WriteLine($"{partyGoingGuests[i]}");
            }
        }
    }
}
