namespace ListManipulationAdvanced
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
            string command = String.Empty;
            int addC = 0;
            int removeC = 0;
            int removeATC = 0;
            int insertCounter = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> curCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (curCommand[0] == "Add")
                {
                    numbers.Add(int.Parse(curCommand[1]));
                    addC++;
                }
                else if (curCommand[0] == "Remove")
                {
                    numbers.Remove(int.Parse(curCommand[1]));
                    removeC++;
                }
                else if (curCommand[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(curCommand[1]));
                    removeATC++;
                }
                else if (curCommand[0] == "Insert")
                {
                    numbers.Insert(int.Parse(curCommand[2]), int.Parse(curCommand[1]));
                    insertCounter++;
                }
                else if (curCommand[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(curCommand[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (curCommand[0] == "PrintEven")
                {
                    PrintsEvenNumbers(numbers);
                }
                else if (curCommand[0] == "PrintOdd")
                {
                    PrintsOddNumbers(numbers);
                }
                else if (curCommand[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (curCommand[0] == "Filter")
                {
                    PrintsFilteredNumbers(curCommand, numbers);
                }
            }

            if (addC != 0 || removeC != 0 || removeATC != 0 || insertCounter != 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static void PrintsFilteredNumbers(List<string> curCommand, List<int> numbers)
        {
            if (curCommand[1] == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > int.Parse(curCommand[2]))
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                Console.WriteLine();
            }
            else if (curCommand[1] == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < int.Parse(curCommand[2]))
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                Console.WriteLine();
            }
            else if (curCommand[1] == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= int.Parse(curCommand[2]))
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                Console.WriteLine();
            }
            else if (curCommand[1] == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= int.Parse(curCommand[2]))
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void PrintsEvenNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static void PrintsOddNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
