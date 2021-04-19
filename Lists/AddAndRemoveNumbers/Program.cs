namespace AddAndRemoveNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse)
                .ToList();
            int timesToLoop = numbersInput.Count / 2;
            for (int i = 0; i < timesToLoop; i++)
            {
                numbersInput[i] += numbersInput[numbersInput.Count - 1];
                numbersInput.RemoveAt(numbersInput.Count - 1);
            }

            Console.WriteLine(String.Join(" ", numbersInput));
        }
    }
}
