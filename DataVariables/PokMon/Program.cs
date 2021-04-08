namespace PokMon
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustingFactor = int.Parse(Console.ReadLine());
            int currPokePower = pokePower;
            int targetsPoked = 0;

            while (currPokePower >= distanceBetweenTargets)
            {
                currPokePower -= distanceBetweenTargets;
                targetsPoked++;
                if (currPokePower == pokePower * 0.5 && exhaustingFactor != 0)
                {
                    currPokePower /= exhaustingFactor;
                }
            }

            Console.WriteLine($"{currPokePower}");
            Console.WriteLine($"{targetsPoked}");
        }
    }
}
