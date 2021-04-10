namespace ZigZag
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int inputLinesToFollow = int.Parse(Console.ReadLine());
            string[] arrayOne = new string[inputLinesToFollow];
            string[] arrayTwo = new string[inputLinesToFollow];
            for (int i = 0; i < inputLinesToFollow; i++)
            {
                string[] currInput = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    arrayOne[i] = currInput[0];
                    arrayTwo[i] = currInput[1];
                }
                else
                {
                    arrayTwo[i] = currInput[0];
                    arrayOne[i] = currInput[1];
                }
            }

            Console.WriteLine(string.Join(" ", arrayOne));
            Console.WriteLine(string.Join(" ", arrayTwo));
        }
    }
}
