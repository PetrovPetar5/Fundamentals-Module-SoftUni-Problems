namespace MiddleCharacters
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputLength = input.Length / 2;
            PrintsTheMiddleLetters(input, inputLength);
        }
        static void PrintsTheMiddleLetters(string input, int inputLength)
        {
            string result = string.Empty;
            if (input.Length % 2 == 0)
            {
                result += input[inputLength - 1].ToString();
                result += input[inputLength].ToString();
            }
            else
            {
                result += input[inputLength].ToString();
            }

            Console.WriteLine(result);
        }
    }
}
