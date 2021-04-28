namespace CompanyUsers
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new SortedDictionary<string, HashSet<string>>();
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string companyName = commandArgs[0];
                string employeeID = commandArgs[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new HashSet<string>());
                }

                companies[companyName].Add(employeeID);
            }

            foreach (var kvp in companies)
            {
                Console.WriteLine(kvp.Key.Trim());
                foreach (var ID in kvp.Value)
                {
                    Console.WriteLine($"-- {ID.Trim()}");
                }
            }
        }
    }
}
