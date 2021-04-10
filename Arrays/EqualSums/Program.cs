namespace EqualSums
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int answer = 0;
            bool isFound = false;
            for (int i = 0; i < inputArray.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                if (i != 0)
                {
                    for (int g = i - 1; g >= 0; g--)
                    {
                        leftSum += inputArray[g];
                    }
                }

                for (int k = i + 1; k < inputArray.Length; k++)
                {
                    rightSum += inputArray[k];
                }

                if (leftSum == rightSum || inputArray.Length == 1)
                {
                    answer = i;
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
