namespace StoreBoxes
{
    using StoreBoxes.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var endCommand = "end";
            var curCommand = String.Empty;
            var boxes = new List<Box>();
            while ((curCommand = Console.ReadLine()) != endCommand)
            {
                var curBoxArgs = curCommand.Split();
                var serialNumber = curBoxArgs[0];
                var itemName = curBoxArgs[1];
                var itemPrice = decimal.Parse(curBoxArgs[3]);
                var itemQuantity = int.Parse(curBoxArgs[2]);
                var curItem = new Item(itemName, itemPrice);
                var curBox = new Box(serialNumber, curItem, itemQuantity);
                boxes.Add(curBox);
            }

             boxes = boxes.OrderByDescending(x => x.Price).ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
