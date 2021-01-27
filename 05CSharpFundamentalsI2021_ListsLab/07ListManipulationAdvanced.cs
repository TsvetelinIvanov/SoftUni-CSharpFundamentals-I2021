using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> originalNumbers = new List<int>(numbers);
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
                    case "Contains":
                        int numberToSearch = int.Parse(commandLine[1]);
                        bool contains = numbers.Contains(numberToSearch);
                        if (contains)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;
                    case "PrintEven":
                        int[] evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
                        Console.WriteLine(string.Join(" ", evenNumbers));
                        break;
                    case "PrintOdd":
                        int[] oddNumbers = numbers.Where(n => n % 2 != 0).ToArray();
                        Console.WriteLine(string.Join(" ", oddNumbers));
                        break;
                    case "GetSum":
                        int numbersSum = numbers.Sum();
                        Console.WriteLine(numbersSum);
                        break;
                    case "Filter":
                        string condition = commandLine[1];
                        int conditionNumber = int.Parse(commandLine[2]);
                        switch (condition)
                        {
                            case "<":
                                int[] lessNumbers = numbers.Where(n => n < conditionNumber).ToArray();
                                Console.WriteLine(string.Join(" ", lessNumbers));
                                break;
                            case ">":
                                int[] greaterNumbers = numbers.Where(n => n > conditionNumber).ToArray();
                                Console.WriteLine(string.Join(" ", greaterNumbers));
                                break;
                            case "<=":
                                int[] lessOrEqualNumbers = numbers.Where(n => n <= conditionNumber).ToArray();
                                Console.WriteLine(string.Join(" ", lessOrEqualNumbers));
                                break;
                            case ">=":
                                int[] greaterOrEqualNumbers = numbers.Where(n => n >= conditionNumber).ToArray();
                                Console.WriteLine(string.Join(" ", greaterOrEqualNumbers));
                                break;
                        }

                        break;
                }
            }

            if (!numbers.SequenceEqual(originalNumbers))
            {
                Console.WriteLine(string.Join(" ", numbers));
            }            
        }
    }
}
