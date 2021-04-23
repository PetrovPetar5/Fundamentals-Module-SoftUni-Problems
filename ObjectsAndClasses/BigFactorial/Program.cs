namespace BigFactorial
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
           
            for (int i = 0; i < number; i++)
            {
                factorial += factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
