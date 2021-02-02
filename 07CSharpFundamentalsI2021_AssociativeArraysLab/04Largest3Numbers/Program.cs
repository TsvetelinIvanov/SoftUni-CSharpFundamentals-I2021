using System;
using System.Linq;

namespace _04Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).ToArray();
            for (int i = 0; i < Math.Min(3, numbers.Length); i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}