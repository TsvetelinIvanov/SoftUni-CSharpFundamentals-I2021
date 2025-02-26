using System;
using System.Linq;
using System.Collections.Generic;

namespace _03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine().Split().ToList();
            List<string> secondList = Console.ReadLine().Split().ToList();
            
            List<string> mergedList = new List<string>();
            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                mergedList.Add(firstList[i]);
                mergedList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                string[] remainigElements = GetRemiainingElements(firstList, secondList);
                mergedList.AddRange(remainigElements);
            }
            else if (secondList.Count > firstList.Count)
            {
                string[] remainigElements = GetRemiainingElements(secondList, firstList);
                mergedList.AddRange(remainigElements);
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }

        private static string[] GetRemiainingElements(List<string> longerList, List<string> shorterList)
        {
            List<string> remainingElements = new List<string>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                remainingElements.Add(longerList[i]);
            }

            return remainingElements.ToArray();
        }
    }
}
