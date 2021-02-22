using System;
using System.Linq;
using System.Collections.Generic;

namespace _03Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();
            string input;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string command = input.Split(" - ").First();
                string item = input.Split(" - ").Last();
                switch (command)
                {
                    case "Collect":
                        if (!inventory.Contains(item))
                        {
                            inventory.Add(item);
                        }

                        break;
                    case "Drop":
                        inventory.Remove(item);
                        break;
                    case "Combine Items":
                        CombineItems(inventory, item);
                        break;
                    case "Renew":
                        if (inventory.Contains(item))
                        {
                            inventory.Remove(item);
                            inventory.Add(item);
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(", ", inventory));
        }

        private static void CombineItems(List<string> inventory, string item)
        {
            string oldItem = item.Split(':').First();
            int oldItemIndex = inventory.IndexOf(oldItem);
            if (oldItemIndex == -1)
            {
                return;
            }
            
            string newItem = item.Split(':').Last();
            inventory.Insert(oldItemIndex + 1, newItem);
        }
    }
}