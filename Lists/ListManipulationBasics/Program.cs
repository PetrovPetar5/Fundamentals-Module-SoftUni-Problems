namespace ListManipulationBasics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> curCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (curCommand[0] == "Add")
                {
                    inputNumbers.Add(int.Parse(curCommand[1]));
                }
                else if (curCommand[0] == "Remove")
                {
                    inputNumbers.Remove(int.Parse(curCommand[1]));
                }
                else if (curCommand[0] == "RemoveAt")
                {
                    inputNumbers.RemoveAt(int.Parse(curCommand[1]));
                }
                else if (curCommand[0] == "Insert")
                {
                    inputNumbers.Insert(int.Parse(curCommand[2]), int.Parse(curCommand[1]));
                }
            }

            Console.WriteLine(String.Join(" ", inputNumbers));
        }
    }
}
