namespace CalculateRectangleArea
{
    using System;
    class Program
    {

        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double result = CalculatesRectangleArea(length, width);
            Console.WriteLine(result);
        }
        static double CalculatesRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}
