namespace Orders
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();
            Dictionary<string, uint> productsQuan = new Dictionary<string, uint>();
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] curCommand = command.Split();
                string curName = curCommand[0];
                decimal curPrice = decimal.Parse(curCommand[1]);
                uint quntity = uint.Parse(curCommand[2]);

                if (!(productsPrice.ContainsKey(curName) && productsQuan.ContainsKey(curName)))
                {
                    productsPrice[curName] = 0;
                    productsQuan[curName] = 0;
                }

                productsPrice[curName] = curPrice;
                productsQuan[curName] += quntity;
            }

            foreach (var kvp in productsPrice)
            {
                string name = kvp.Key;
                uint quantity = productsQuan[name];
                decimal price = productsPrice[name];
                Console.WriteLine($"{kvp.Key} -> {price * quantity:f2}");
            }
        }
    }
}
