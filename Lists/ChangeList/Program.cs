namespace ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> curCommandElements = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (curCommandElements[0] == "Insert")
                {
                    numbers.Insert(int.Parse(curCommandElements[2]), int.Parse(curCommandElements[1]));
                }
                else if (curCommandElements[0] == "Delete")
                {
                    while (numbers.Contains(int.Parse(curCommandElements[1])))
                    {
                        numbers.Remove(int.Parse(curCommandElements[1]));
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
