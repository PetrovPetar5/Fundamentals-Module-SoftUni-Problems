namespace NxNMatrix
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numberToPrintNTimes = int.Parse(Console.ReadLine());
            PrintsANumberNTimes(numberToPrintNTimes);
        }

        static void PrintsANumberNTimes(int numberToPrintNTimes)
        {
            for (int a = 0; a < numberToPrintNTimes; a++)
            {
                for (int i = 0; i < numberToPrintNTimes; i++)
                {
                    Console.Write(numberToPrintNTimes + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
