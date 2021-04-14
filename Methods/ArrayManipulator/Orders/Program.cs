namespace Orders
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int productQuantity = int.Parse(Console.ReadLine());
            PrintsOrderFinalPrice(product, productQuantity);
        }
        static void PrintsOrderFinalPrice(string product, int productQuantity)
        {
            if (product == "coffee")
            {
                Console.WriteLine($"{productQuantity * 1.5:F2}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{productQuantity * 1:f2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{productQuantity * 1.4:f2}");
            }
            else
            {
                Console.WriteLine($"{productQuantity * 2:f2}");
            }
        }
    }
}
