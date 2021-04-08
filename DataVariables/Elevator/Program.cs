namespace Elevator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int personsNumber = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int timesToElevate = (int)Math.Ceiling(personsNumber / (double)elevatorCapacity);
            
            Console.WriteLine(timesToElevate);
        }
    }
}
