namespace ListOperations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                List<string> curCommandElements = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (curCommandElements[0] == "Add")
                {
                    numbers.Add(int.Parse(curCommandElements[1]));
                }
                else if (curCommandElements[0] == "Insert")
                {
                    numbers = InsertsIndexOrPrintsInvalid(curCommandElements, numbers);
                }
                else if (curCommandElements[0] == "Remove")
                {
                    numbers = RemovesIndexOrPrintsInvalid(curCommandElements, numbers);
                }
                else if (curCommandElements[1] == "left")
                {
                    int timesToLoop = int.Parse(curCommandElements[2]);
                    numbers = MovesListToTheLeftNTimes(timesToLoop, numbers);
                }
                else if (curCommandElements[1] == "right")
                {
                    int timesToLoop = int.Parse(curCommandElements[2]);
                    numbers = MovesListToTheRightNTimes(timesToLoop, numbers);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static List<int> InsertsIndexOrPrintsInvalid(List<string> curCommandElements, List<int> numbers)
        {
            if (int.Parse(curCommandElements[2]) >= 0 && int.Parse(curCommandElements[2]) <= numbers.Count - 1)
            {
                numbers.Insert(int.Parse(curCommandElements[2]), int.Parse(curCommandElements[1]));
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

            return numbers;
        }

        static List<int> RemovesIndexOrPrintsInvalid(List<string> curCommandElements, List<int> numbers)
        {
            if (int.Parse(curCommandElements[1]) >= 0 && int.Parse(curCommandElements[1]) <= numbers.Count - 1)
            {
                numbers.RemoveAt(int.Parse(curCommandElements[1]));
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

            return numbers;
        }

        static List<int> MovesListToTheLeftNTimes(int timesToLoop, List<int> numbers)
        {
            for (int i = 0; i < timesToLoop; i++)
            {
                int temp = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(temp);
            }

            return numbers;
        }

        static List<int> MovesListToTheRightNTimes(int timesToLoop, List<int> numbers)
        {
            for (int i = 0; i < timesToLoop; i++)
            {
                int temp = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, temp);
            }

            return numbers;
        }
    }
}
