using System;

namespace _06StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = number;
            int factorialsSum = 0;
            while (currentNumber > 0)
            {
                int currentDigit = currentNumber % 10;
                currentNumber /= 10;
                int currentDigitFactorial = 1;
                for (int i = 1; i <= currentDigit; i++)
                {
                    currentDigitFactorial *= i;
                }

                factorialsSum += currentDigitFactorial;
            }

            if (number == factorialsSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
