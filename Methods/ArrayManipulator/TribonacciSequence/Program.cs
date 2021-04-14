namespace TribonacciSequence
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = { 0, 0, 1, 0 };
            Console.Write(1 + " ");
            for (int i = 1; i < input; i++)
            {
                arr[3] = arr[0] + arr[1] + arr[2];
                Console.Write(arr[3] + " ");
                for (int a = 0; a < arr.Length - 1; a++)
                {
                    arr[a] = arr[a + 1];
                }
            }
        }
    }
}
