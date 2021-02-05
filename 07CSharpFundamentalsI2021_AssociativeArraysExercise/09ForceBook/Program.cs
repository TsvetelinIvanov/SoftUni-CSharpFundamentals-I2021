using System;
using System.Linq;
using System.Collections.Generic;

namespace _09ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();
            ReadInput(sides);
            PrintSides(sides);
        }

        private static void ReadInput(Dictionary<string, List<string>> sides)
        {
            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    string side = input.Split(" | ").First();
                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>());
                    }

                    string user = input.Split(" | ").Last();
                    if (!sides.Any(s => s.Value.Contains(user)))
                    {
                        sides[side].Add(user);
                    }
                }
                else if (input.Contains(" -> "))
                {
                    string user = input.Split(" -> ").First();
                    string side = input.Split(" -> ").Last();
                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>());
                    }

                    if (!sides.Any(sides => sides.Value.Contains(user)))
                    {
                        if (!sides[side].Contains(user))
                        {
                            sides[side].Add(user);
                        }
                    }
                    else
                    {
                        foreach (List<string> forceSide in sides.Values)
                        {
                            forceSide.Remove(user);
                        }

                        if (!sides[side].Contains(user))
                        {
                            sides[side].Add(user);
                        }
                    }                                     

                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }
        }

        private static void PrintSides(Dictionary<string, List<string>> sides)
        {
            foreach (KeyValuePair<string, List<string>> side in sides.Where(s => s.Value.Count > 0).OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (string user in side.Value.OrderBy(u => u))
                {
                    Console.WriteLine("! " + user);
                }
            }
        }
    }
}