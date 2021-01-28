using System;
using System.Linq;
using System.Collections.Generic;

namespace _02ChangeList
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
                    case "Delete":
                        int numberToDelete = int.Parse(commandLine[1]);
                        numbers.RemoveAll(n => n == numberToDelete);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commandLine[1]);
                        int index = int.Parse(commandLine[2]);
                        numbers.Insert(index, numberToInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
