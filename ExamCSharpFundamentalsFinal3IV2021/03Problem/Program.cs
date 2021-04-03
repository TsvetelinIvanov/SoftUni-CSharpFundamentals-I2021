using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestsAndMeals = new Dictionary<string, List<string>>();
            int unlikedMealsCount = 0;
            string mealDataString;
            while ((mealDataString = Console.ReadLine()) != "Stop")
            {
                string[] mealData = mealDataString.Split('-');
                string command = mealData[0];
                string guest = mealData[1];
                string meal = mealData[2];
                switch (command)
                {
                    case "Like":
                        if (!guestsAndMeals.ContainsKey(guest))
                        {
                            guestsAndMeals.Add(guest, new List<string>());
                        }

                        if (!guestsAndMeals[guest].Contains(meal))
                        {
                            guestsAndMeals[guest].Add(meal);
                        }

                        break;
                    case "Unlike":
                        if (!guestsAndMeals.ContainsKey(guest))
                        {
                            Console.WriteLine($"{guest} is not at the party.");

                            break;
                        }

                        if (!guestsAndMeals[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");

                            break;
                        }

                        guestsAndMeals[guest].Remove(meal);
                        unlikedMealsCount++;
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        break;
                    default:
                        throw new ArgumentException("Invalid command!");
                }
            }

            foreach (KeyValuePair<string, List<string>> guestAndMeals in guestsAndMeals.OrderByDescending(gm => gm.Value.Count).ThenBy(gm => gm.Key))
            {
                Console.WriteLine($"{guestAndMeals.Key}: {string.Join(", ", guestAndMeals.Value)}".TrimEnd());
            }

            Console.WriteLine("Unliked meals: " + unlikedMealsCount);
        }
    }
}