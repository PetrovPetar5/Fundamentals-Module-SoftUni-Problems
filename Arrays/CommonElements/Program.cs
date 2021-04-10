namespace CommonElements
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstUserInput = Console.ReadLine().Split();
            string[] secondUserInput = Console.ReadLine().Split();
            string commonWords = string.Empty;

            foreach (var secondArrayWord in secondUserInput)
            {
                foreach (var firstArrayWord in firstUserInput)
                {
                    if (secondArrayWord == firstArrayWord)
                    {
                        commonWords = string.Concat(secondArrayWord + " ");
                    }
                }
            }

            Console.WriteLine(commonWords);
        }
    }
}
