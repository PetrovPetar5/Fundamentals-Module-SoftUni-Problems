namespace TopNumber
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 8; i <= input; i++)
            {
                string number = i.ToString();
                int curNum = ReturnSumOfNumberDigits(number);
                if (curNum % 8 != 0)
                {
                    continue;
                }

                if (ChecksIfThereIsAnOddDigit(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
        static int ReturnSumOfNumberDigits(string iToString)
        {
            int curNum = 0;
            for (int a = 0; a < iToString.Length; a++)
            {
                curNum += int.Parse(iToString[a].ToString());
            }

            return curNum;
        }
        static bool ChecksIfThereIsAnOddDigit(string iToString)
        {
            int oddDigit = 0;
            for (int b = 0; b < iToString.Length; b++)
            {
                int curDigitCheck = int.Parse(iToString[b].ToString());
                if (curDigitCheck % 2 != 0)
                {
                    oddDigit++;
                }
            }

            if (oddDigit != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

