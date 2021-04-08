namespace TownInfo
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            long townPopulation = long.Parse(Console.ReadLine());
            short townArea = short.Parse(Console.ReadLine());
            Console.WriteLine("Town {0} has population of {1} and area {2} square km.", townName, townPopulation, townArea);
        }
    }
}
