namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestSeriaC = 0;
            string result = string.Empty;
            string numberToAdd = string.Empty;

            for (int i = 0; i < inputElements.Length; i++)
            {
                int sequenceCounter = 0;
                for (int k = i + 1; k < inputElements.Length; k++)
                {
                    if (inputElements[i] == inputElements[k])
                    {
                        sequenceCounter++;

                    }
                    else
                    {
                        break;
                    }
                }

                if (sequenceCounter > bestSeriaC)
                {
                    result = string.Empty;
                    bestSeriaC = sequenceCounter;
                    for (int a = 0; a < bestSeriaC; a++)
                    {
                        result += inputElements[i].ToString() + " ";
                        numberToAdd = inputElements[i].ToString();
                    }
                }
            }

            Console.WriteLine(result + numberToAdd);
        }
    }
}
