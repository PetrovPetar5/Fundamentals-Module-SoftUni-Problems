namespace PrintPartOfTheASCIITable
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int tempEnd = 0;
            int tempStart = 0;
            if (startNumber > endNumber)
            {
                tempEnd = startNumber;
                tempStart = endNumber;
            }
            else
            {
                tempEnd = endNumber;
                tempStart = startNumber;
            }

            for (int i = tempStart; i <= tempEnd; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}