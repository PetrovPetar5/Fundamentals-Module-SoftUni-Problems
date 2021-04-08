namespace BeerKegs
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int kegsNumber = int.Parse(Console.ReadLine());
            decimal biggestKegVolume = decimal.MinValue;
            string biggestKegModel = string.Empty;

            for (int i = 0; i < kegsNumber; i++)
            {
                string currKegModel = Console.ReadLine();
                double currKegRadius = double.Parse(Console.ReadLine());
                int currKegHeight = int.Parse(Console.ReadLine());
                decimal currKegVolume = (decimal)Math.PI * (decimal)Math.Pow(currKegRadius, 2) * currKegHeight;

                if (biggestKegVolume < currKegVolume)
                {
                    biggestKegVolume = currKegVolume;
                    biggestKegModel = currKegModel;
                }
            }

            Console.WriteLine($"{biggestKegModel}");
        }
    }
}
