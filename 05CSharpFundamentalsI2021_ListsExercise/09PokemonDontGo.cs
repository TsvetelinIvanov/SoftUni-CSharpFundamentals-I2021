using System;
using System.Collections.Generic;
using System.Linq;

namespace _09PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int removedPokemonsSum = 0;
            while (pokemons.Count > 0)
            {
                int pokemonIndex = int.Parse(Console.ReadLine());

                if (pokemonIndex < 0)
                {
                    int changedPokemonValue = pokemons[0];
                    pokemons.RemoveAt(0);
                    removedPokemonsSum += changedPokemonValue;
                    int copiedPokemonValue = pokemons.Last();
                    pokemons.Insert(0, copiedPokemonValue);
                    ProcessPokemons(pokemons, changedPokemonValue);
                    continue;
                }

                if (pokemonIndex >= pokemons.Count)
                {
                    int changedPokemonValue = pokemons.Last();
                    pokemons.RemoveAt(pokemons.Count - 1);
                    removedPokemonsSum += changedPokemonValue;
                    int copiedPokemonValue = pokemons[0];
                    pokemons.Add(copiedPokemonValue);
                    ProcessPokemons(pokemons, changedPokemonValue);
                    continue;
                }

                int pokemonValue = pokemons[pokemonIndex];
                pokemons.RemoveAt(pokemonIndex);
                removedPokemonsSum += pokemonValue;
                ProcessPokemons(pokemons, pokemonValue);
            }

            Console.WriteLine(removedPokemonsSum);
        }

        private static void ProcessPokemons(List<int> pokemons, int pokemonValue)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= pokemonValue)
                {
                    pokemons[i] += pokemonValue;
                }
                else
                {
                    pokemons[i] -= pokemonValue;
                }
            }
        }
    }
}
