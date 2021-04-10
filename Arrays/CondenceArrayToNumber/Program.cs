namespace Train
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int vagonsNum = int.Parse(Console.ReadLine());
            int[] peoplePerVagon = new int[vagonsNum];
            int totalPeople = 0;

            for (int i = 0; i < peoplePerVagon.Length; i++)
            {
                peoplePerVagon[i] = int.Parse(Console.ReadLine());
                totalPeople += peoplePerVagon[i];
            }

            string peopleInVagons = string.Join(" ", peoplePerVagon);
            Console.WriteLine(peopleInVagons);
            Console.WriteLine(totalPeople);
        }
    }
}
