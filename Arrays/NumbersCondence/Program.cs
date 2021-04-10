
namespace NumbersCondence
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] curNumbers = new int[numbers.Length - 1];
            while (numbers.Length != 1)
            {
                curNumbers = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    curNumbers[i] = numbers[i] + numbers[i + 1];
                }

                numbers = curNumbers.ToArray();
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
