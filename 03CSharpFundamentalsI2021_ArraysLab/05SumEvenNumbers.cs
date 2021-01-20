using System;
using System.Linq;

namespace _05SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenNumbersSum = numbers.Where(n => n % 2 == 0).Sum();
            Console.WriteLine(evenNumbersSum);
        }
    }
}
