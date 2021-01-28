using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "End")
            {
                string[] commandLine = commandLineString.Split();
                string command = commandLine[0];
                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandLine[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commandLine[1]);
                        int indexToInsert = int.Parse(commandLine[2]);
                        bool isInArray = CheckIndex(numbers, indexToInsert);
                        if (isInArray)
                        {
                            numbers.Insert(indexToInsert, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(commandLine[1]);
                        isInArray = CheckIndex(numbers, indexToRemove);
                        if (isInArray)
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        
                        break;
                    case "Shift":
                        string direction = commandLine[1];
                        int count = int.Parse(commandLine[2]) % numbers.Count;
                        switch (direction)
                        {
                            case "left":
                                for (int i = 1; i <= count; i++)
                                {
                                    int numberToShift = numbers[0];
                                    numbers.RemoveAt(0);
                                    numbers.Add(numberToShift);
                                }

                                break;
                            case "right":
                                for (int i = 1; i <= count; i++)
                                {
                                    int numberToShift = numbers[numbers.Count - 1];
                                    numbers.RemoveAt(numbers.Count - 1);
                                    numbers.Insert(0, numberToShift);
                                }

                                break;
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool CheckIndex(List<int> list, int index)
        {
            return index >= 0 && index < list.Count;
        }
    }
}
