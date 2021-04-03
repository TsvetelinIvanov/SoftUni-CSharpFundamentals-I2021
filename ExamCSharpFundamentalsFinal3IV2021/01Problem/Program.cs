using System;

namespace _01Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "End")
            {
                string[] commandLine = commandLineString.Split();
                string command = commandLine[0];
                switch (command)
                {
                    case "Translate":
                        string replaced = commandLine[1];
                        string replacement = commandLine[2];
                        text = text.Replace(replaced, replacement);
                        Console.WriteLine(text);
                        break;
                    case "Includes":
                        string includedString = commandLine[1];
                        Console.WriteLine(text.Contains(includedString));
                        break;
                    case "Start":
                        string startedString = commandLine[1];
                        Console.WriteLine(text.StartsWith(startedString));
                        break;
                    case "Lowercase":                        
                        text = text.ToLower();
                        Console.WriteLine(text);
                        break;
                    case "FindIndex":
                        string indexed = commandLine[1];                        
                        int index = text.LastIndexOf(indexed);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        int startIndex = int.Parse(commandLine[1]);
                        int count = int.Parse(commandLine[2]);                        
                        text = text.Remove(startIndex, count);
                        Console.WriteLine(text);
                        break;
                    default:
                        throw new ArgumentException("Invalid command!");
                }
            }
        }
    }
}