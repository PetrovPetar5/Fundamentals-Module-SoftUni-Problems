namespace RefactorVolumePyramid
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            Console.Write($"Length:" + " ");
            double width = double.Parse(Console.ReadLine());
            Console.Write($"Width:" + " ");
            double heigth = double.Parse(Console.ReadLine());
            Console.Write($"Heigth:" + " ");
            double volumeFormula = (length * width * heigth) / 3;
            Console.Write($"Pyramid Volume: {volumeFormula:f2} ");
        }
    }
}
