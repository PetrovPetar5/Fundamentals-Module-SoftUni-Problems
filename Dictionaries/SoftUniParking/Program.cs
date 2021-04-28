namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            byte commandsToFollow = byte.Parse(Console.ReadLine());
            Dictionary<string, string> registerNumbers = new Dictionary<string, string>();
            for (int i = 0; i < commandsToFollow; i++)
            {
                string[] coElements = Console.ReadLine().Split();
                string firstElement = coElements[0];
                string name = coElements[1];
                if (firstElement == "register")
                {
                    if (!registerNumbers.ContainsKey(name))
                    {
                        registerNumbers[name] = coElements[2];
                        Console.WriteLine($"{name} registered {coElements[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registerNumbers[name]}");
                    }
                }
                else
                {
                    if (registerNumbers.ContainsKey(name))
                    {
                        registerNumbers.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }

            foreach (var kvp in registerNumbers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
