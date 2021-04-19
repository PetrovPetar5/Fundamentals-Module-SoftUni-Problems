namespace BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            List<int> specialnumberanditspower = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int specialnumber = specialnumberanditspower[0];
            int power = specialnumberanditspower[1];
            while (numbers.Contains(specialnumber))
            {
                int specialnumindex = numbers.IndexOf(specialnumber);
                int leftnumbers = specialnumindex - power;
                int rightnumbers = specialnumindex + power;
                if (specialnumindex - power < 0)
                {
                    leftnumbers = 0;
                }

                if ((specialnumindex + power) > (numbers.Count - 1))
                {
                    rightnumbers = numbers.Count - 1;

                }

                numbers.RemoveRange(leftnumbers, rightnumbers - leftnumbers + 1);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
