using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "end")
            {
                string[] commandLine = commandLineString.Split();
                string command = commandLine[0];
                switch (command)
                {
                    case "Add":
                        int numberToAdding = int.Parse(commandLine[1]);
                        numbers.Add(numberToAdding);
                        break;
                    case "Remove":
                        int numberToRemoving = int.Parse(commandLine[1]);
                        numbers.Remove(numberToRemoving);
                        break;
                    case "RemoveAt":
                        int indexToRemoving = int.Parse(commandLine[1]);
                        numbers.RemoveAt(indexToRemoving);
                        break;
                    case "Insert":
                        int numberToInserting = int.Parse(commandLine[1]);
                        int indexToInserting = int.Parse(commandLine[2]);
                        numbers.Insert(indexToInserting, numberToInserting);
                        break;
                }                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
