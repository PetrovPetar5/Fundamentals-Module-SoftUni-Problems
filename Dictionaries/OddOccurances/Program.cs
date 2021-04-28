namespace OddOccurances
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            var oddOccurances = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string curWord = word.ToLower();
                if (!oddOccurances.ContainsKey(curWord))
                {
                    oddOccurances[curWord] = 0;
                }

                oddOccurances[curWord]++;
            }

            foreach (var occurance in oddOccurances)
            {
                if (occurance.Value % 2 != 0)
                {
                    Console.Write(occurance.Key + " ");
                }
            }
        }
    }
}
