namespace RoundingNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double[] arrNumbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arrNumbers[i] = double.Parse(input[i]);
            }

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                if (arrNumbers[i] == 0)
                {
                    arrNumbers[i] = 0;
                }
                
                Console.WriteLine($"{arrNumbers[i]} => {(int)Math.Round(arrNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
