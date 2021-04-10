namespace ReverseArrayOfStrings
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputToArray = input.Split();

            for (int i = 0; i < inputToArray.Length / 2; i++)
            {
                string temp = inputToArray[i];
                string last = inputToArray[inputToArray.Length - 1 - i];
                inputToArray[inputToArray.Length - 1 - i] = temp;
                inputToArray[i] = last;
            }

            string result = string.Join(" ", inputToArray);
            Console.WriteLine(result);
        }
    }
}
