using System;
using System.Linq;
using System.Collections.Generic;

namespace _02Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sugarCubes = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "Mort")
            {
                string[] commandLine = input.Split();
                string command = commandLine[0];
                int value = int.Parse(commandLine[1]);
                switch (command)
                {
                    case "Add":
                        sugarCubes.Add(value);
                        break;
                    case "Remove":
                        for (int i = 0; i < sugarCubes.Count; i++)
                        {
                            if (sugarCubes[i] == value)
                            {
                                sugarCubes.RemoveAt(i);
                                break;
                            }
                        }
                        
                        break;
                    case "Replace":
                        int replacement = int.Parse(commandLine[2]);
                        for (int i = 0; i < sugarCubes.Count; i++)
                        {
                            if (sugarCubes[i] == value)
                            {
                                sugarCubes[i] = replacement;
                                break;
                            }
                        }

                        break;
                    case "Collapse":
                        sugarCubes.RemoveAll(v => v < value);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", sugarCubes));
        }
    }
}