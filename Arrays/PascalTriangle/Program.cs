namespace PascalTriangle
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int linesToPrint = int.Parse(Console.ReadLine());
            for (int i = 0; i < linesToPrint; i++)
            {
                for (int b = 0; b < i + 1; b++)
                {
                    Console.Write("1" + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
