using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            IEnumerable<int> top5GreaterThanAverageNumbers = numbers.Where(n => n > numbers.Average()).OrderByDescending(n => n).Take(5);
            Console.WriteLine(top5GreaterThanAverageNumbers.Count() > 0 ? string.Join(" ", top5GreaterThanAverageNumbers) : "No");
        }
    }
}
