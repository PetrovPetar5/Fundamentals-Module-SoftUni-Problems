namespace ReversedChars
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondtInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", thirdInput, secondtInput, firstInput);
        }
    }
}
