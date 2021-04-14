namespace PalindromeInteger
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(ChecksIfPalindrome(input));
                input = Console.ReadLine();
            }
        }
        static string ChecksIfPalindrome(string input)
        {
            string inputReversed = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                inputReversed += (input[input.Length - 1 - i]).ToString();
            }

            if (inputReversed == input)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}
