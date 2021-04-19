namespace Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacityPerWagon = int.Parse(Console.ReadLine());
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> curCommandElements = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (curCommandElements[0] == "Add")
                {
                    wagons.Add(int.Parse(curCommandElements[1]));
                }
                else
                {
                    int curPassengersToAdd = int.Parse(curCommandElements[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((curPassengersToAdd + wagons[i]) <= maxCapacityPerWagon)
                        {
                            wagons[i] += curPassengersToAdd;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
