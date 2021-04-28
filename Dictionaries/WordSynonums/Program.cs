namespace WordSynonums
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            byte loopTimes = byte.Parse(Console.ReadLine());
            var synonyms = new Dictionary<string, HashSet<string>>();
            for (int i = 0; i < loopTimes; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = new HashSet<string>();

                }

                synonyms[word].Add(synonym);
            }

            var sb = new StringBuilder();
            foreach (var synonym in synonyms)
            {
                sb.AppendLine($"{synonym.Key} - {String.Join(", ", synonym.Value)}");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
