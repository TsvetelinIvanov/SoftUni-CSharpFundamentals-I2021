using System;

namespace _05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                int digitsSum = 0;
                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber /= 10;
                    digitsSum += currentDigit;
                }

                bool isSpecialNumber = digitsSum == 5 || digitsSum == 7 || digitsSum == 11;
                Console.WriteLine(i + " -> " + isSpecialNumber);
            }
        }
    }
}
