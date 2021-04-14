namespace SmallestOfNumbers
{
    using System;
    class Program
    {
        static int GivesTheSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            return Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int smallestNumber = GivesTheSmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(smallestNumber);
        }
    }
}
