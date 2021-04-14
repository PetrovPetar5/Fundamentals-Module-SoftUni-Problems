namespace AddSubtract
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int thirdInput = int.Parse(Console.ReadLine());
            int firstSecondSum = GivesSum(firstInput, secondInput);
            int result = GivesFirstSecondSumMinus(firstSecondSum, thirdInput);
            Console.WriteLine(result);
        }

        static int GivesSum(int firstInput, int secondInput)
        {
            return firstInput + secondInput;
        }

        static int GivesFirstSecondSumMinus(int firstSecondSum, int thirdInput)
        {
            return firstSecondSum - thirdInput;
        }
    }
}
