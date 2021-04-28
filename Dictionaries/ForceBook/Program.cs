namespace ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var usersSides = new Dictionary<string, HashSet<string>>();
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] coArgs = command.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                if (command.Contains("|"))
                {
                    string side = coArgs[0];
                    string user = coArgs[1];
                    AddsSide(usersSides, side);
                    AddUserToSide(usersSides, side, user);
                }
                else if (command.Contains("->"))
                {
                    string side = coArgs[1];
                    string user = coArgs[0];
                    AddsSide(usersSides, side);
                    foreach (var kvp in usersSides)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            kvp.Value.Remove(user);
                            break;
                        }
                    }

                    usersSides[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            usersSides = usersSides.Where(l => l.Value.Count > 0).OrderByDescending(l => l.Value.Count).ThenBy(l => l.Key)
               .ToDictionary(a => a.Key, b => b.Value);
            foreach (var kvp in usersSides)
            {
                List<string> curUsers = kvp.Value.OrderBy(user => user).ToList();
                Console.WriteLine($"Side: { kvp.Key}, Members: { kvp.Value.Count}");
                foreach (var user in curUsers)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }

        private static void AddsSide(Dictionary<string, HashSet<string>> usersSides, string side)
        {
            if (!usersSides.ContainsKey(side))
            {
                usersSides.Add(side, new HashSet<string>());
            }
        }

        private static void AddUserToSide(Dictionary<string, HashSet<string>> usersSides, string side, string user)
        {
            if (!usersSides.Values.Any(u => u.Contains(user)))
            {
                usersSides[side].Add(user);
            }
        }
    }
}
