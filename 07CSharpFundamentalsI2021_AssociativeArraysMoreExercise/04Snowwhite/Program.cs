using System;
using System.Linq;
using System.Collections.Generic;

namespace _04Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            ReadRawDuarfsData(dwarfs);
            PrintOrderedDuarfsData(dwarfs);
        }

        private static void ReadRawDuarfsData(Dictionary<string, int> dwarfs)
        {
            string dwarfDataString;
            while ((dwarfDataString = Console.ReadLine()) != "Once upon a time")
            {
                string[] dwarfData = dwarfDataString.Split(" <:> ");
                string name = dwarfData[0];
                string hatColor = dwarfData[1];
                int phisics = int.Parse(dwarfData[2]);
                string dwarf = name + " " + hatColor;
                if (!dwarfs.ContainsKey(dwarf) || dwarfs[dwarf] < phisics)
                {
                    dwarfs[dwarf] = phisics;
                }
            }
        }

        private static void PrintOrderedDuarfsData(Dictionary<string, int> dwarfs)
        {
            foreach (KeyValuePair<string, int> dwarf in dwarfs.OrderByDescending(d => d.Value).ThenByDescending(d => dwarfs.Count(dw => dw.Key.Split()[1] == d.Key.Split()[1])))
            {                
                Console.WriteLine($"({dwarf.Key.Split()[1]}) {dwarf.Key.Split()[0]} <-> {dwarf.Value}");
            }
        }
    }
}
