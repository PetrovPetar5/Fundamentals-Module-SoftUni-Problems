namespace DataTypeFinder
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                BigInteger intInput = 0;
                double doubleInput = 0;
                bool booleanInput = false;
                char charInput = '\0';

                bool integer = BigInteger.TryParse(input, out intInput);
                bool floating = double.TryParse(input, out doubleInput);
                bool boleanResult = Boolean.TryParse(input, out booleanInput);
                bool charResult = char.TryParse(input, out charInput);

                if (integer)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (floating)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (boleanResult)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (charResult)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
