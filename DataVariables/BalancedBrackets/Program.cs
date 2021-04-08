namespace BalancedBrackets
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            int openingBracketC = 0;
            int closingBracketC = 0;

            for (int i = 0; i < linesCount; i++)
            {
                string currInput = Console.ReadLine();

                if (currInput == "(")
                {
                    openingBracketC++;
                }
                else if (currInput == ")")
                {
                    closingBracketC++;
                    if (openingBracketC - closingBracketC != 0)
                    {
                        break;
                    }
                }
            }

            if (openingBracketC == closingBracketC)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
