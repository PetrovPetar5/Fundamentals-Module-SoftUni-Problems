namespace RandomizeWords
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var rand = new Random();
            for (int i = 0; i < inputWords.Length; i++)
            {
                inputWords[i] = inputWords[rand.Next(0, inputWords.Length)];
            }

            Console.WriteLine(String.Join(Environment.NewLine, inputWords));
        }
    }
}
