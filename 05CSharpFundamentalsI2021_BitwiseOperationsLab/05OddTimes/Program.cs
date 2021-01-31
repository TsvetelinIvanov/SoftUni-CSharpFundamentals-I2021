using System;
using System.Linq;

namespace _05OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int oddOccuredNumber = 0;
            foreach (int number in numbers)
            {
                oddOccuredNumber ^= number;                
            }

            Console.WriteLine(oddOccuredNumber);
        }
    }
}