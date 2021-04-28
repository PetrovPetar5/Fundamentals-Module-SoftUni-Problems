namespace CountCharsInAString
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> charsInText = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    string curWord = words[i];
                    string curLetter = curWord[j].ToString();
                    if (!charsInText.ContainsKey(curLetter))
                    {
                        charsInText[curLetter] = 0;
                    }

                    charsInText[curLetter]++;
                }
            }

            foreach (var chara in charsInText)
            {
                Console.WriteLine($"{chara.Key} -> {chara.Value}");
            }
        }
    }
}
