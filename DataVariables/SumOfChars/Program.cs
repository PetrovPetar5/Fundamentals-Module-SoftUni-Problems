namespace SumOfChars
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int charsCount = int.Parse(Console.ReadLine());
            int charSum = 0;
            for (int i = 0; i < charsCount; i++)
            {
                char curChar = char.Parse(Console.ReadLine());
                charSum += curChar;
            }

            Console.WriteLine($"The sum equals: {charSum}");
        }
    }
}
