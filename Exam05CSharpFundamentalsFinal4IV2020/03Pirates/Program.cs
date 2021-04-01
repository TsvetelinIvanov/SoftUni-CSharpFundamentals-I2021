using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> cities = new Dictionary<string, int[]>();
            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] cityData = input.Split("||");
                string cityName = cityData[0];
                int population = int.Parse(cityData[1]);
                int gold = int.Parse(cityData[2]);
                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, new int[] { population, gold });
                }
                else
                {
                    cities[cityName][0] += population;
                    cities[cityName][1] += gold;
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] eventData = input.Split("=>");                
                string @event = eventData[0];
                string[] arguments = eventData.Skip(1).ToArray();
                switch (@event)
                {
                    case "Plunder":
                        PlunderCity(cities, arguments);
                        break;
                    case "Prosper":
                        ProsperCity(cities, arguments);
                        break;
                    default:
                        throw new ArgumentException("Invalid event!");
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (KeyValuePair<string, int[]> city in cities.OrderByDescending(c => c.Value[1]).ThenBy(c => c.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        private static void PlunderCity(Dictionary<string, int[]> cities, string[] arguments)
        {
            string cityName = arguments[0];
            int peopleCount = int.Parse(arguments[1]);
            int gold = int.Parse(arguments[2]);
            cities[cityName][0] -= peopleCount;
            cities[cityName][1] -= gold;
            Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {peopleCount} citizens killed.");
            if (cities[cityName][0] <= 0 || cities[cityName][1] <= 0)
            {
                cities.Remove(cityName);
                Console.WriteLine(cityName + " has been wiped off the map!");
            }
        }

        private static void ProsperCity(Dictionary<string, int[]> cities, string[] arguments)
        {
            string cityName = arguments[0];
            int gold = int.Parse(arguments[1]);
            if (gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
                return;
            }

            cities[cityName][1] += gold;
            Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cities[cityName][1]} gold.");
        }
    }
}