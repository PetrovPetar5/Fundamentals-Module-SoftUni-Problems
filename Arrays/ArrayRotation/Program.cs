namespace ArrayRotation
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int timesToRotate = int.Parse(Console.ReadLine());
            for (int i = 0; i < timesToRotate; i++)
            {
                string firstElement = array[0];
                for (int k = 0; k < array.Length - 1; k++)
                {
                    array[k] = array[k + 1];
                }

                array[array.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
