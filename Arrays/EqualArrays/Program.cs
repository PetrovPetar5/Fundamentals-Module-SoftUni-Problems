namespace EqualArrays
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string firstUserInput = Console.ReadLine();
            string secondUserInput = Console.ReadLine();

            string[] firstWords = firstUserInput.Split();
            string[] secondWords = secondUserInput.Split();

            int[] firstArray = new int[firstWords.Length];
            int[] secondArray = new int[secondWords.Length];

            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(firstWords[i]);
                secondArray[i] = int.Parse(secondWords[i]);
                sum += firstArray[i];

                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
           
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
