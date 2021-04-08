namespace WaterOverflow
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            byte pourTimes = byte.Parse(Console.ReadLine());
            short capacity = 255;
            short totalPoured = 0;
            for (byte i = 0; i < pourTimes; i++)
            {
                short currLiters = short.Parse(Console.ReadLine());
                if (currLiters + totalPoured > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalPoured += currLiters;
                }
            }

            Console.WriteLine(totalPoured);
        }
    }
}
