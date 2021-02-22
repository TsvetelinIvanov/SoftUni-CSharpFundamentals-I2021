using System;
using System.Linq;
using System.Collections.Generic;

namespace _02ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split('!').ToList();
            string shoppingCommandString;
            while ((shoppingCommandString = Console.ReadLine()) != "Go Shopping!")
            {
                string[] shoppingCommandArray = shoppingCommandString.Split();
                string command = shoppingCommandArray[0];
                string product = shoppingCommandArray[1];
                switch (command)
                {
                    case "Urgent":
                        if (!groceries.Contains(product))
                        {
                            groceries.Insert(0, product);
                        }

                        break;
                    case "Unnecessary":
                        groceries.Remove(product);
                        break;
                    case "Correct":
                        if (groceries.Contains(product))
                        {
                            string newProduct = shoppingCommandArray[2];
                            int productIndex = groceries.IndexOf(product);
                            groceries[productIndex] = newProduct;
                        }

                        break;
                    case "Rearrange":
                        if (groceries.Contains(product))
                        {
                            groceries.Remove(product);
                            groceries.Add(product);
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}