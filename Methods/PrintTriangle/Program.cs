namespace PrintTriangle
{
    using System;
    class Program
    {
        static void PrintingNumbersFromOneToIInARow(int i)
        {
            for (int row = 1; row <= i; row++)
            {
                Console.Write(row + " ");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int numberToPrintTo = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberToPrintTo; i++)
            {
                PrintingNumbersFromOneToIInARow(i);
            }

            for (int i = numberToPrintTo - 1; i >= 1; i--)
            {
                PrintingNumbersFromOneToIInARow(i);
            }
        }
    }
}
