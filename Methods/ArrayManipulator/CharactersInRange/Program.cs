namespace CharactersInRange
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            PrintsCharsInRange(firstInput, secondInput);
        }

        static void PrintsCharsInRange(char firstInput, char secondInput)
        {
            if (firstInput > secondInput)
            {
                char temp = firstInput;
                firstInput = secondInput;
                secondInput = temp;
            }

            for (int i = firstInput + 1; i <= secondInput - 1; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
