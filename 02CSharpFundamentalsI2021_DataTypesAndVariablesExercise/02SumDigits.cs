using System;

namespace _02SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digitsSum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;
                digitsSum += currentDigit;
            }

            Console.WriteLine(digitsSum);
        }
    }
}
