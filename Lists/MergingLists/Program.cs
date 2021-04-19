namespace MergingLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
           
            List<string> secondNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
           
            List<string> mergedList = new List<string>();
            int mixedListCount = Math.Max(firstNumbers.Count, secondNumbers.Count);
            for (int i = 0; i < mixedListCount; i++)
            {
                if (i > firstNumbers.Count - 1)
                {

                }
                else
                {
                    mergedList.Add(firstNumbers[i]);
                }

                if (i > secondNumbers.Count - 1)
                {

                }
                else
                {
                    mergedList.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", mergedList));
        }
    }
}
