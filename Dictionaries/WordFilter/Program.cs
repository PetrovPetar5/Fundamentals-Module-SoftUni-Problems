namespace WordFilter
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split().Where(product => product.Length % 2 == 0).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, products));
        }
    }
}
