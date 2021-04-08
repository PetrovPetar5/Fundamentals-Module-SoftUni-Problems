namespace IntegerOperations
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long numberOne = long.Parse(Console.ReadLine());
            long numberTwo = long.Parse(Console.ReadLine());
            long numberThree = long.Parse(Console.ReadLine());
            long numberFour = long.Parse(Console.ReadLine());

            Console.WriteLine((numberOne + numberTwo) / numberThree * numberFour);
        }
    }
}
