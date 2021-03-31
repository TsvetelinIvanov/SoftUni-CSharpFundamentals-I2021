using System;
using System.Collections.Generic;
using System.Linq;

namespace _03PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<int, List<int>>> plants = new Dictionary<string, KeyValuePair<int, List<int>>>();
            int plantsCountN = int.Parse(Console.ReadLine());
            for (int i = 0; i < plantsCountN; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");
                string plantName = plantInfo[0].Trim();
                int plantRarity = int.Parse(plantInfo[1].Trim());
                plants[plantName] = new KeyValuePair<int, List<int>>(plantRarity, new List<int>());
            }

            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "Exhibition")
            {
                string[] commandLine = commandLineString.Split(": ");
                string command = commandLine[0];
                string plantName = commandLine[1].Split(" - ").First();
                if (!plants.ContainsKey(plantName))
                {
                    Console.WriteLine("error");
                    
                    continue;
                }

                switch (command)
                {
                    case "Rate":                        
                        int plantRating = int.Parse(commandLine[1].Split(" - ").Last());
                        plants[plantName].Value.Add(plantRating);
                        break;                    
                    case "Update":                        
                        int plantRarity = int.Parse(commandLine[1].Split(" - ").Last());
                        List<int> plantRatings = plants[plantName].Value;
                        plants[plantName] = new KeyValuePair<int, List<int>>(plantRarity, plantRatings);
                        break;
                    case "Reset":
                        plants[plantName].Value.Clear();
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            Dictionary<string, KeyValuePair<int, double>> exhibitedPlants = plants.ToDictionary(p => p.Key, p => new KeyValuePair<int, double>(p.Value.Key, p.Value.Value.Count > 0 ? p.Value.Value.Average() : 0));
            foreach (KeyValuePair<string, KeyValuePair<int, double>> plant in exhibitedPlants.OrderByDescending(p => p.Value.Key).ThenByDescending(p => p.Value.Value)) 
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Key}; Rating: {plant.Value.Value:f2}");
            }
        }
    }
}