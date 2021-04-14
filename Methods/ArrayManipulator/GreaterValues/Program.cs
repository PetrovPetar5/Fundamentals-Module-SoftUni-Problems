namespace GreaterValues
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            string result = string.Empty;
            if (valueType == "int")
            {
                result = PrintsGreaterBetween(BigInteger.Parse(Console.ReadLine()), BigInteger.Parse(Console.ReadLine())) + "";
            }
            else if (valueType == "char")
            {
                result = PrintsGreaterBetween(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())) + "";
            }
            else if (valueType == "string")
            {
                result = PrintsGreaterBetween(Console.ReadLine(), Console.ReadLine());
            }

            Console.WriteLine(result);
        }

        static BigInteger PrintsGreaterBetween(BigInteger firstNumber, BigInteger secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static char PrintsGreaterBetween(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static string PrintsGreaterBetween(string firstInput, string secondInput)
        {
            int result = firstInput.CompareTo(secondInput);
            if (result == 1)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }
        }
    }
}
