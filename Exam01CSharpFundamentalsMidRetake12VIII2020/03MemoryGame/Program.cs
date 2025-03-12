using System;
using System.Linq;
using System.Collections.Generic;

namespace _03MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> twins = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            int turnsCount = 0;
            
            string indicesString;
            while ((indicesString = Console.ReadLine()) != "end" && twins.Count > 0)
            {
                turnsCount++;
                int[] indices = indicesString.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int firstIndex = indices[0];
                int secondIndex = indices[1];
                if (!IsInList(twins, firstIndex) || !IsInList(twins, secondIndex) || firstIndex == secondIndex)
                {
                    twins.Insert(twins.Count / 2, $"-{turnsCount}a");
                    twins.Insert(twins.Count / 2, $"-{turnsCount}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");

                    continue;
                }

                if (twins[firstIndex] == twins[secondIndex])
                {
                    string matchedElement = twins[firstIndex];
                    if (firstIndex > secondIndex)
                    {
                        twins.RemoveAt(firstIndex);
                        twins.RemoveAt(secondIndex);
                    }
                    else
                    {
                        twins.RemoveAt(secondIndex);
                        twins.RemoveAt(firstIndex);
                    }

                    Console.WriteLine($"Congrats! You have found matching elements - {matchedElement}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }                
            }

            if (twins.Count == 0)
            {
                Console.WriteLine($"You have won in {turnsCount} turns!");
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", twins));
            }
        }

        private static bool IsInList(List<string> list, int index)
        {
            return index >= 0 && index < list.Count;
        }
    }
}
