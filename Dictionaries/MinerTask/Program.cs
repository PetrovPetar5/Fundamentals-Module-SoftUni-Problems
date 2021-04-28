namespace MinerTask
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string curWord = String.Empty;
            var mines = new Dictionary<string, int>();
            while ((curWord = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!mines.ContainsKey(curWord))
                {
                    mines[curWord] = 0;
                }

                mines[curWord] += quantity;
            }

            foreach (var mine in mines)
            {
                Console.WriteLine($"{mine.Key} -> {mine.Value}");
            }
        }
    }
}
