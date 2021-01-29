using System;
using System.Collections.Generic;
using System.Linq;

namespace _04MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Reverse(secondNumbers);
            int numbersLength = Math.Min(firstNumbers.Length, secondNumbers.Length);
            List<int> mixedNumbers = new List<int>(numbersLength);
            for (int i = 0; i < numbersLength; i++)
            {
                mixedNumbers.Add(firstNumbers[i]);
                mixedNumbers.Add(secondNumbers[i]);
            }

            int minRangeNumber; 
            int maxRangeNumber;
            if (firstNumbers.Length > secondNumbers.Length)
            {
                minRangeNumber = Math.Min(firstNumbers[numbersLength], firstNumbers[numbersLength + 1]);
                maxRangeNumber = Math.Max(firstNumbers[numbersLength], firstNumbers[numbersLength + 1]);
            }
            else
            {
                minRangeNumber = Math.Min(secondNumbers[numbersLength], secondNumbers[numbersLength + 1]);
                maxRangeNumber = Math.Max(secondNumbers[numbersLength], secondNumbers[numbersLength + 1]);
            }

            List<int> numbersInRange = GetNumbersInRange(mixedNumbers, minRangeNumber, maxRangeNumber);
            numbersInRange.Sort();

            Console.WriteLine(string.Join(" ", numbersInRange));
        }

        private static List<int> GetNumbersInRange(List<int> mixedNumbers, int minRangeNumber, int maxRangeNumber)
        {
            List<int> numbersInRange = new List<int>();
            for (int i = 0; i < mixedNumbers.Count; i++)
            {
                if (mixedNumbers[i] > minRangeNumber && mixedNumbers[i] < maxRangeNumber)
                {
                    numbersInRange.Add(mixedNumbers[i]);
                }
            }

            return numbersInRange;
        }
    }
}
