namespace Treasure
{
    using System;
    using System.Linq;
    class Program
    {
        static string[] BringsCurrentTreasure(string[] command, string[] initialTreasureItems)
        {
            string[] curTreasureItems = { "" };
            for (int i = 1; i <= command.Length - 1; i++)
            {
                if (initialTreasureItems.Contains(command[i]))
                {
                    continue;
                }
                else
                {
                    curTreasureItems = new string[initialTreasureItems.Length + 1];
                    for (int a = 1; a <= initialTreasureItems.Length; a++)
                    {
                        curTreasureItems[a] = initialTreasureItems[a - 1];
                    }

                    curTreasureItems[0] = command[i];
                }

                initialTreasureItems = curTreasureItems.ToArray();
            }

            return initialTreasureItems;
        }

        static string[] DropsAnIndexAtTheEndOfTheArray(string[] command, string[] curTreasureItems)
        {
            int curIndex = int.Parse(command[1]);
            string temp = curTreasureItems[curIndex];
            for (int i = curIndex; i < curTreasureItems.Length - 1; i++)
            {
                curTreasureItems[i] = curTreasureItems[i + 1];
            }

            curTreasureItems[curTreasureItems.Length - 1] = temp;
            return curTreasureItems;
        }

        static void Main(string[] args)
        {
            string[] initialTreasureItems = Console.ReadLine().Split(new string[] { " ", "|" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string curCommand = String.Empty;
            string[] curTreasureItems = initialTreasureItems.ToArray();
            bool isFailed = false;

            while ((curCommand = Console.ReadLine()) != "Yohoho!")
            {
                string[] command = curCommand.Split().ToArray();

                if (command[0] == "Loot")
                {
                    curTreasureItems = BringsCurrentTreasure(command, curTreasureItems);
                }
                else if (command[0] == "Drop")
                {
                    int curIndex = int.Parse(command[1]);
                    if (curIndex > curTreasureItems.Length - 1 || curIndex < 0)
                    {
                        continue;
                    }

                    curTreasureItems = DropsAnIndexAtTheEndOfTheArray(command, curTreasureItems);
                }
            }
        }
    }
}