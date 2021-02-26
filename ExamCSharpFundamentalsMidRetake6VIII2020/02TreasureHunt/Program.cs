using System;
using System.Linq;
using System.Collections.Generic;

namespace _02TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split('|').ToList();
            string input;
            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                string[] commandLine = input.Split();
                string command = commandLine[0];
                switch (command)
                {
                    case "Loot":
                        InsertItems(chest, commandLine.Skip(1));
                        break;
                    case "Drop":
                        int index = int.Parse(commandLine[1]);
                        if (IsInChest(chest, index))
                        {
                            string item = chest[index];
                            chest.RemoveAt(index);
                            chest.Add(item);
                        }
                        
                        break;
                    case "Steal":
                        int count = int.Parse(commandLine[1]);
                        chest = RemoveAndPrintItems(chest, count);
                        break;
                }
            }

            if (chest.Count > 0)
            {
                double averageGain = (double)chest.Sum(i => i.Length) / chest.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }

        private static void InsertItems(List<string> chest, IEnumerable<string> items)
        {
            foreach (string item in items)
            {
                if (!chest.Contains(item))
                {
                    chest.Insert(0, item);
                }
            }
        }

        private static bool IsInChest(List<string> chest, int index)
        {
            return index >= 0 && index < chest.Count;
        }

        private static List<string> RemoveAndPrintItems(List<string> chest, int count)
        {
            if (count >= chest.Count)
            {
                Console.WriteLine(string.Join(", ", chest));
                chest.Clear();

                return chest;
            }

            IEnumerable<string> stealedItems = chest.TakeLast(count);            
            Console.WriteLine(string.Join(", ", stealedItems));

            return chest.SkipLast(count).ToList();
        }
    }
}