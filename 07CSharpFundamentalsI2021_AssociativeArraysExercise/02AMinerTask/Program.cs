using System;
using System.Collections.Generic;

namespace _02AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                int quantity = int.Parse(Console.ReadLine());
                resources[resource] += quantity;
            }

            foreach (KeyValuePair<string, int> recourceQuantity in resources)
            {
                Console.WriteLine($"{recourceQuantity.Key} -> {recourceQuantity.Value}");
            }
        }
    }
}