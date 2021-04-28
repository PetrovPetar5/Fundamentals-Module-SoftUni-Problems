namespace SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> uNamesLanguages = new Dictionary<string, List<string>>();
            Dictionary<string, int> uNamePoints = new Dictionary<string, int>();
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "exam finished")
            {
                string[] commandArgs = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string curUName = commandArgs[0];
                string curLanguageOBanned = commandArgs[1];
                if (curLanguageOBanned == "banned")
                {
                    foreach (var kvp in uNamePoints)
                    {
                        if (kvp.Key == curUName)
                        {
                            uNamePoints.Remove(curUName);
                            break;
                        }
                    }
                }
                else
                {
                    if (!uNamesLanguages.Keys.Contains(curLanguageOBanned))
                    {
                        uNamesLanguages.Add(curLanguageOBanned, new List<string>());
                    }

                    uNamesLanguages[curLanguageOBanned].Add(curUName);

                    int curPoints = int.Parse(commandArgs[2]);
                    if (uNamePoints.Keys.Contains(curUName) && curPoints > uNamePoints[curUName])
                    {
                        uNamePoints[curUName] = curPoints;
                    }
                    else if (!uNamePoints.Keys.Contains(curUName))
                    {
                        uNamePoints.Add(curUName, curPoints);
                    }
                }
            }

            uNamePoints = uNamePoints
                .OrderByDescending(value => value.Value)
                .ThenBy(name => name.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            uNamesLanguages = uNamesLanguages
                .OrderByDescending(value => value.Value.Count)
                .ThenBy(name => name.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine(ReturnsResultAsPerTask(uNamesLanguages, uNamePoints));
        }

        private static string ReturnsResultAsPerTask(Dictionary<string, List<string>> uNamesLanguages, Dictionary<string, int> uNamePoints)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Results:");
            foreach (var kvp in uNamePoints)
            {
                sb.AppendLine($"{kvp.Key} | {kvp.Value}");
            }

            sb.AppendLine("Submissions:");
            foreach (var kvp in uNamesLanguages)
            {
                sb.AppendLine($"{kvp.Key} - {kvp.Value.Count}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
