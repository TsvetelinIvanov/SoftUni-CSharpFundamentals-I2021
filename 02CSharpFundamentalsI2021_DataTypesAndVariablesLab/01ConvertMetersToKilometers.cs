using System;

namespace _01ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int metersCount = int.Parse(Console.ReadLine());
            decimal kilometersCount = metersCount / 1000.0m;
            Console.WriteLine($"{kilometersCount:f2}");
        }
    }
}
