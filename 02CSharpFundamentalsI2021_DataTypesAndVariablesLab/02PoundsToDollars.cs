using System;

namespace _02PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal poundsCount = decimal.Parse(Console.ReadLine());
            decimal dollarsCount = poundsCount * 1.31m;
            Console.WriteLine($"{dollarsCount:f3}");
        }
    }
}
