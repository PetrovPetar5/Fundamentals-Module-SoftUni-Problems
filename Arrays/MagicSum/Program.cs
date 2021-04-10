namespace MagicSum
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int specialNum = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    if (numbers[a] + numbers[b] == specialNum)
                    {
                        Console.Write(numbers[a] + " " + numbers[b]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
