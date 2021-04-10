namespace EncryptSortPrintArray
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int inputsToFollow = int.Parse(Console.ReadLine());
            int[] scores = new int[inputsToFollow];

            for (int a = 0; a < inputsToFollow; a++)
            {
                string curName = Console.ReadLine();
                int curResult = 0;
                for (int b = 0; b < curName.Length; b++)
                {

                    int curLetter = curName[b];
                    if (curLetter == 'A' || curLetter == 'E' || curLetter == 'I' || curLetter == 'O' || curLetter == 'U' || curLetter == 'a' || curLetter == 'e' || curLetter == 'i' || curLetter == 'o' || curLetter == 'u')
                    {
                        curResult += curLetter * curName.Length;
                    }
                    else
                    {
                        curResult += (int)Math.Floor(curLetter * 1.0 / curName.Length);
                    }
                }

                scores[a] = curResult;
            }

            Array.Sort(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }
    }
}
