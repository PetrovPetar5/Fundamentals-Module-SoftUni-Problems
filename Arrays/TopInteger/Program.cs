namespace TopInteger
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isBigger = true;
                for (int k = i+1; k < arr.Length; k++)
                {
                    if (arr[i] <= arr[k])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    result += (arr[i] + " ").ToString();
                }
            }

            Console.WriteLine(result);
        }
    }
}
