namespace DayOfWeek
{
    using System;
    using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            var dayOfWeak = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dayOfWeak.DayOfWeek);
        }
    }
}
