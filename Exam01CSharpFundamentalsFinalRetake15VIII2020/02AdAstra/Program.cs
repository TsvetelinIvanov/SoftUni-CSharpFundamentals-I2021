using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CaloriesPerDay = 2000;
            Regex foodInfoRegex = new Regex(@"(#|\|)(?<itemName>[A-Za-z ]+)\1(?<expirationDate>\d{2}/\d{2}/\d{2})\1(?<caloriesCount>\d{1,5})\1");
            List<string> foodData = new List<string>();
            int totalCaloriesCount = 0;
            
            string rawFoodInfoString = Console.ReadLine();
            MatchCollection foodInfoMatches = foodInfoRegex.Matches(rawFoodInfoString);
            foreach (Match foodInfoMatch in foodInfoMatches)
            {
                string itemName = foodInfoMatch.Groups["itemName"].Value;
                string expirationDate = foodInfoMatch.Groups["expirationDate"].Value;
                int caloriesCount = int.Parse(foodInfoMatch.Groups["caloriesCount"].Value);
                totalCaloriesCount += caloriesCount;
                
                string foodInfo = $"Item: {itemName}, Best before: {expirationDate}, Nutrition: {caloriesCount}";
                foodData.Add(foodInfo);
            }

            int foodDaysCount = totalCaloriesCount / CaloriesPerDay;
            Console.WriteLine($"You have food to last you for: {foodDaysCount} days!");
            Console.WriteLine(string.Join(Environment.NewLine, foodData));
        }
    }
}
