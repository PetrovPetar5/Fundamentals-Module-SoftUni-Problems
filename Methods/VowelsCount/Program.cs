namespace VowelsCount
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReturnsVowelCount(input));
        }

        static int ReturnsVowelCount(string input)
        {
            int vowelCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char curLetter = input[i];
                if (curLetter == 'O' || curLetter == 'o' || curLetter == 'U' || curLetter == 'u' || curLetter == 'I' || curLetter == 'i' || curLetter == 'A' || curLetter == 'a' || curLetter == 'E' || curLetter == 'e')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
