using System;
using System.Linq;
using System.Collections.Generic;

namespace _05DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, int[]>> dragons = new Dictionary<string, SortedDictionary<string, int[]>>();
            ReadRawDragonData(dragons);
            PrintOrderedDragonData(dragons);            
        }

        private static void ReadRawDragonData(Dictionary<string, SortedDictionary<string, int[]>> dragons)
        {
            int dragonsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < dragonsCount; i++)
            {
                string[] dragonData = Console.ReadLine().Split();
                string type = dragonData[0];
                string name = dragonData[1];
                int damage = dragonData[2] == "null" ? 45 : int.Parse(dragonData[2]);
                int health = dragonData[3] == "null" ? 250 : int.Parse(dragonData[3]);
                int armor = dragonData[4] == "null" ? 10 : int.Parse(dragonData[4]);

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, int[]>());
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new int[3];
                }

                dragons[type][name][0] = damage;
                dragons[type][name][1] = health;
                dragons[type][name][2] = armor;
            }
        }

        private static void PrintOrderedDragonData(Dictionary<string, SortedDictionary<string, int[]>> dragons)
        {
            foreach (KeyValuePair<string, SortedDictionary<string, int[]>> dragonType in dragons)
            {
                double averageDamage = dragonType.Value.Average(d => d.Value[0]);
                double averageHealth = dragonType.Value.Average(d => d.Value[1]);
                double averageArmor = dragonType.Value.Average(d => d.Value[2]);
                Console.WriteLine($"{dragonType.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (KeyValuePair<string, int[]> dragon in dragonType.Value)
                {
                    int damage = dragon.Value[0];
                    int health = dragon.Value[1];
                    int armor = dragon.Value[2];
                    Console.WriteLine($"-{dragon.Key} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}