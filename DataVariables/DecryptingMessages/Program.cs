namespace DecryptingMessages
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            byte numberToAdd = byte.Parse(Console.ReadLine());
            byte numbersToFollow = byte.Parse(Console.ReadLine());
            string decryptedMess = string.Empty;

            for (int i = 0; i < numbersToFollow; i++)
            {
                char currLetter = Char.Parse(Console.ReadLine());
                currLetter = (char)(currLetter + numberToAdd);
                decryptedMess += currLetter;
            }

            Console.WriteLine(decryptedMess);
        }
    }
}
