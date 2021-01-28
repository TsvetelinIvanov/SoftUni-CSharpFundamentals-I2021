using System;
using System.Linq;
using System.Collections.Generic;

namespace _08AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split().ToList();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "3:1")
            {
                string[] commandLine = commandLineString.Split();
                string command = commandLine[0];
                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(commandLine[1]);
                        int endIndex = int.Parse(commandLine[2]);
                        MergeStrings(strings, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(commandLine[1]);
                        int partitionsCount = int.Parse(commandLine[2]);
                        DivideStrings(strings, index, partitionsCount);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", strings));
        }

        private static void MergeStrings(List<string> strings, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (startIndex > strings.Count - 1)
            {
                startIndex = strings.Count - 1;
            }

            if (endIndex > strings.Count - 1)
            {
                endIndex = strings.Count - 1;
            }

            string mergedString = string.Empty;            
            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedString += strings[startIndex];
                strings.RemoveAt(startIndex);                              
            }

            strings.Insert(startIndex, mergedString);
        }

        private static void DivideStrings(List<string> strings, int index, int partitionsCount)
        {
            string stringToDivide = strings[index];
            strings.RemoveAt(index);
            int partitionLength = stringToDivide.Length / partitionsCount;
            List<string> partitions = new List<string>();            
            for (int i = 0; i < partitionsCount; i++)
            {               
                if (i == partitionsCount - 1)
                {
                    partitions.Add(stringToDivide.Substring(i * partitionLength));                   
                }
                else
                {
                    partitions.Add(stringToDivide.Substring(i * partitionLength, partitionLength));
                }
            }           

            strings.InsertRange(index, partitions);
        }
    }
}
