namespace TreasureHunt
{
    using System;
    using System.Data;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            for (int a = 0; a < ladyBugIndexes.Length; a++)
            {
                if (ladyBugIndexes[a] >= 0 && ladyBugIndexes[a] <= field.Length - 1)
                {
                    field[ladyBugIndexes[a]] = ladyBugIndexes[a];
                    field[ladyBugIndexes[a]] = 1;
                }
            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] curCommand = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int landIndex = 0;
                int curIndexToMove = int.Parse(curCommand[0]);
                string direction = curCommand[1];
                int flyLength = int.Parse(curCommand[2]);

                if (direction == "right")
                {
                    landIndex += curIndexToMove + flyLength;
                    if (curIndexToMove >= 0 && curIndexToMove <= field.Length - 1 && field[curIndexToMove] != 0)
                    {
                        field[curIndexToMove] = 0;

                        while (landIndex <= field.Length - 1)
                        {
                            if (field[landIndex] == 0 && field[landIndex] >= 0 && field[landIndex] <= field.Length - 1)
                            {
                                field[landIndex] = 1;
                                break;
                            }

                            landIndex += flyLength;
                        }
                    }
                }
                else if (direction == "left")
                {

                    landIndex = curIndexToMove - flyLength;
                    if (curIndexToMove >= 0 && curIndexToMove <= field.Length - 1 && field[curIndexToMove] != 0)
                    {
                        field[curIndexToMove] = 0;

                        while (landIndex >= 0)
                        {
                            if (field[landIndex] == 0 && field[landIndex] >= 0 && field[landIndex] <= field.Length - 1)
                            {
                                field[landIndex] = 1;
                                break;
                            }

                            landIndex -= flyLength;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
