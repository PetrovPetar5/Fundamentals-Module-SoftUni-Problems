namespace SumOfEvenNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            string[] inpuToArray = inputNumbers.Split();
            int[] inputToInt = new int[inpuToArray.Length];
            int evenNumberSum = 0;

            for (int i = 0; i < inpuToArray.Length; i++)
            {
                inputToInt[i] = int.Parse(inpuToArray[i]);

                if (inputToInt[i] % 2 == 0)
                {
                    evenNumberSum += inputToInt[i];
                }
            }

            Console.WriteLine(evenNumberSum);
        }
    }
}
