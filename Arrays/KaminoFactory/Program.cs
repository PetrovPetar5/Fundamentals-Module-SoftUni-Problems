namespace KaminoFactory
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            int bestSequence = 0;
            int sampleCounter = 0;
            int bestSampleNumber = 0;
            int bestIndex = 0;
            int bestSum = 0;
            int[] bestResult = { 0 };
            string inputNumbers = Console.ReadLine();
            while (inputNumbers != "Clone them!")
            {
                int[] samplesDNA = inputNumbers.Split(new[] { "!" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sampleCounter++;
                int currSequence = 0;
                int curIndex = 0;

                for (int i = 0; i < samplesDNA.Length; i++)
                {
                    curIndex = i;
                    if (samplesDNA[i] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        for (int a = i + 1; a < samplesDNA.Length; a++)
                        {
                            if (samplesDNA[a] == 1)
                            {
                                currSequence++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (currSequence > bestSequence || currSequence == bestSequence && curIndex < bestIndex || samplesDNA.Sum() > bestSum)
                        {
                            bestSequence = currSequence;
                            bestSampleNumber = sampleCounter;
                            bestIndex = i;
                            bestResult = samplesDNA.ToArray();
                            bestSum = samplesDNA.Sum();
                        }

                        currSequence = 0;
                    }
                }

                inputNumbers = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", bestResult));
        }
    }
}
