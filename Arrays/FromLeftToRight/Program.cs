namespace FromLeftToRight
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int inputsToFollow = int.Parse(Console.ReadLine());
            for (int a = 0; a < inputsToFollow; a++)
            {
                long[] curArray = Console.ReadLine().Split().Select(long.Parse).ToArray();
                string curNumber = String.Empty;
                long curResult = 0;
                if (curArray[0] > curArray[1])
                {
                    curNumber = Math.Abs(curArray[0]).ToString();
                    for (int b = 0; b < curNumber.Length; b++)
                    {
                        curResult += long.Parse(curNumber[b].ToString());
                    }
                }
                else
                {
                    curNumber = Math.Abs(curArray[1]).ToString();
                    for (int b = 0; b < curNumber.Length; b++)
                    {
                        curResult += long.Parse(curNumber[b].ToString());
                    }
                }

                Console.WriteLine(curResult);
            }
        }
    }
}
