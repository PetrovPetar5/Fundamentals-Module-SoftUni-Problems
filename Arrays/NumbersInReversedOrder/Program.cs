﻿namespace NumbersInReversedOrder
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int inputsToFollow = int.Parse(Console.ReadLine());
            int[] numbers = new int[inputsToFollow];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = inputsToFollow - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
