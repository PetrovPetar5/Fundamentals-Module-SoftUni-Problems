namespace CharsToString
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char symbolOne = char.Parse(Console.ReadLine());
            char symbolTwo = char.Parse(Console.ReadLine());
            char symbolThree = char.Parse(Console.ReadLine());

            Console.WriteLine($"{symbolOne}{symbolTwo}{symbolThree}");
        }
    }
}
