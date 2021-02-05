using System;
using System.Linq;
using System.Collections.Generic;

namespace _03LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
            {
                ["shards"] = 0,
                ["fragments"] = 0,
                ["motes"] = 0
            };
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            while (true)
            {
                string[] inputMaterials = Console.ReadLine().Split();
                for (int i = 0; i < inputMaterials.Length; i += 2)
                {
                    int quantity = int.Parse(inputMaterials[i]);
                    string material = inputMaterials[i + 1].ToLower();                    
                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }

                    if (keyMaterials.Any(km => km.Value >= 250))
                    {
                        break;
                    }
                }

                if (keyMaterials.Any(km => km.Value >= 250))
                {
                    break;
                }
            }

            if (keyMaterials["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                keyMaterials["shards"] -= 250;
            }
            else if (keyMaterials["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                keyMaterials["fragments"] -= 250;
            }
            else if (keyMaterials["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                keyMaterials["motes"] -= 250;
            }

            foreach (KeyValuePair<string, int> keyMaterial in keyMaterials.OrderByDescending(km => km.Value).ThenBy(km => km.Key))
            {
                Console.WriteLine($"{keyMaterial.Key}: {keyMaterial.Value}");
            }

            foreach (KeyValuePair<string, int> junkMaterial in junkMaterials.OrderBy(jm => jm.Key))
            {
                Console.WriteLine($"{junkMaterial.Key}: {junkMaterial.Value}");
            }
        }
    }
}