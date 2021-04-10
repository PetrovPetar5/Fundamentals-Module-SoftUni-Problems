namespace Ladybugs
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] friendsNames = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] command = Console.ReadLine().Split();
            int blacklistedCounter = 0;
            int lostCounter = 0;
            while (command[0] != "Report")
            {
                long curIndexToChange = 0;
                if (command[0] == "Blacklist")
                {
                    bool isFound = false;
                    for (int i = 0; i < friendsNames.Length; i++)
                    {
                        if (command[1] == friendsNames[i])
                        {
                            Console.WriteLine($"{friendsNames[i]} was blacklisted.");
                            friendsNames[i] = "Blacklisted";
                            blacklistedCounter++;
                            isFound = true;
                            break;
                        }
                    }

                    if (isFound == false)
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                    }
                }
                else if (command[0] == "Error")
                {
                    curIndexToChange = long.Parse(command[1]);
                    if (curIndexToChange >= 0 && curIndexToChange <= friendsNames.Length - 1)
                    {
                        if (friendsNames[curIndexToChange] != "Blacklisted" && friendsNames[curIndexToChange] != "Lost")
                        {
                            Console.WriteLine($"{friendsNames[curIndexToChange]} was lost due to an error.");
                            friendsNames[curIndexToChange] = "Lost";
                            lostCounter++;
                        }
                    }
                }
                else if (command[0] == "Change")
                {
                    curIndexToChange = long.Parse(command[1]);
                    if (curIndexToChange >= 0 && curIndexToChange <= friendsNames.Length - 1)
                    {
                        Console.WriteLine($"{friendsNames[curIndexToChange]} changed his username to {command[2]}.");
                        friendsNames[curIndexToChange] = command[2];
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Blacklisted names: {blacklistedCounter}");
            Console.WriteLine($"Lost names: {lostCounter}");
            Console.WriteLine(String.Join(" ", friendsNames));
        }
    }
}
