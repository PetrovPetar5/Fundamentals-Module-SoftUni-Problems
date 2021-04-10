namespace TaskPlanner
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            long[] timesForTasks = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            string command = Console.ReadLine();
            long curIndex = 0;
            while (command != "End")
            {
                string[] curCommand = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int result = 0;
                if (curCommand[0] == "Complete")
                {

                    curIndex = long.Parse(curCommand[1]);
                    if (0 <= curIndex && curIndex <= timesForTasks.Length - 1)
                    {
                        timesForTasks[curIndex] = 0;
                    }

                }
                else if (curCommand[0] == "Change")
                {

                    curIndex = long.Parse(curCommand[1]);
                    if (0 <= curIndex && curIndex <= timesForTasks.Length - 1)
                    {
                        timesForTasks[curIndex] = long.Parse(curCommand[2]);
                    }

                }
                else if (curCommand[0] == "Drop")
                {

                    curIndex = long.Parse(curCommand[1]);
                    if (0 <= curIndex && curIndex <= timesForTasks.Length - 1)
                    {
                        timesForTasks[curIndex] = -1;
                    }

                }
                else if (curCommand[1] == "Completed")
                {

                    for (int i = 0; i < timesForTasks.Length; i++)
                    {
                        if (timesForTasks[i] == 0)
                        {
                            result++;
                        }
                    }

                    Console.WriteLine(result);
                }
                else if (curCommand[1] == "Dropped")
                {
                    for (int i = 0; i < timesForTasks.Length; i++)
                    {

                        if (timesForTasks[i] == -1)
                        {
                            result++;
                        }
                    }

                    Console.WriteLine(result);
                }
                else if (curCommand[1] == "Incomplete")
                {
                    for (int i = 0; i < timesForTasks.Length; i++)
                    {

                        if (timesForTasks[i] != -1 && timesForTasks[i] != 0)
                        {
                            result++;
                        }
                    }

                    Console.WriteLine(result);
                }

                command = Console.ReadLine();
            }

            string incompleatedTasksRemained = string.Empty;
            for (int i = 0; i < timesForTasks.Length; i++)
            {
                if (timesForTasks[i] != -1 && timesForTasks[i] != 0)
                {
                    incompleatedTasksRemained += timesForTasks[i] + " ";
                }
            }

            Console.WriteLine(incompleatedTasksRemained);
        }
    }
}
