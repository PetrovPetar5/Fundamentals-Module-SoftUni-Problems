namespace AppendArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> arraysToPrint = new List<int>();
            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                List<int> curArrayElements = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int a = 0; a < curArrayElements.Count; a++)
                {
                    arraysToPrint.Add(curArrayElements[a]);
                }
            }

            Console.WriteLine(String.Join(" ", arraysToPrint));
        }
    }
}
