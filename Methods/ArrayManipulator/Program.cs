namespace ArrayManipulator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int intInput = int.Parse(Console.ReadLine());
                GivesResult(intInput);
            }
            else if (dataType == "real")
            {
                double doubleInput = double.Parse(Console.ReadLine());
                GivesResult(doubleInput);
            }
            else
            {
                string stringInput = Console.ReadLine();
                GivesResult(stringInput);
            }
        }

        static void GivesResult(int input)
        {
            Console.WriteLine(input * 2);
        }

        static void GivesResult(double input)
        {
            Console.WriteLine($"{input * 1.5:f2}");
        }

        static void GivesResult(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}
