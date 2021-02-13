using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>([A-Za-z]+)<<(\d+(?:\.\d+)?)\!(\d+)\b";
            List<string> furniture = new List<string>();
            decimal totalPrice = 0;
            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match furnitureData = Regex.Match(input, pattern);
                if (furnitureData.Success)
                {
                    string furnitureName = furnitureData.Groups[1].Value;
                    decimal price = decimal.Parse(furnitureData.Groups[2].Value);
                    int quantity = int.Parse(furnitureData.Groups[3].Value);
                    furniture.Add(furnitureName);
                    totalPrice += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            if (furniture.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }
            
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}