namespace FactorialDivision
{
    using System;
    class Program
    {
        
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            decimal result = GivesFactorialOf(firstInput) / GivesFactorialOf(secondInput);
            Console.WriteLine($"{result:f2}");
        }
        static decimal GivesFactorialOf(int input)
        {
            if (input == 0 || input == 1)
            {
                return 1;
            }
            else
            {
                long factorial = 1;
                for (int i = 1; i <= input; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }
        }
    }
}

