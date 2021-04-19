namespace PokemonDontGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            int sumOfRemovedElements = 0;
            while (pokemons.Count != 0)
            {
                int curIndex = int.Parse(Console.ReadLine());
                int temp = 0;
                if (curIndex < 0)
                {
                    temp = pokemons[0];
                    pokemons.RemoveAt(0);
                    sumOfRemovedElements += temp;
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                    ChangesUpOrDownValuesOfArray(pokemons, temp);
                }
                else if (curIndex > pokemons.Count - 1)
                {
                    temp = pokemons[pokemons.Count - 1];
                    pokemons.RemoveAt(pokemons.Count - 1);
                    sumOfRemovedElements += temp;
                    pokemons.Add(pokemons[0]);
                    ChangesUpOrDownValuesOfArray(pokemons, temp);
                }
                else
                {
                    temp = pokemons[curIndex];
                    pokemons.RemoveAt(curIndex);
                    sumOfRemovedElements += temp;
                    ChangesUpOrDownValuesOfArray(pokemons, temp);
                }
            }

            Console.WriteLine(sumOfRemovedElements);
        }

        static void ChangesUpOrDownValuesOfArray(List<int> pokemons, int temp)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= temp)
                {
                    pokemons[i] += temp;
                }
                else
                {
                    pokemons[i] -= temp;
                }
            }
        }
    }
}
