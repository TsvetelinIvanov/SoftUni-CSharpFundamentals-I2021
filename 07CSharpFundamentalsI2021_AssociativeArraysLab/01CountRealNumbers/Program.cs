using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> numbersCounts = new SortedDictionary<double, int>();
            foreach (double number in numbers)
            {
                if (!numbersCounts.ContainsKey(number))
                {
                    numbersCounts[number] = 0;
                }

                numbersCounts[number]++;
            }

            foreach (KeyValuePair<double, int> nuberCount in numbersCounts)
            {
                Console.WriteLine(nuberCount.Key + " -> " + nuberCount.Value);
            }
        }
    }
}