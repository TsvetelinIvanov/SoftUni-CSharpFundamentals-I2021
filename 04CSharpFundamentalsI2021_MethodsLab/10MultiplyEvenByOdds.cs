using System;

namespace _10MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = MultiplyEvenByOddDigits(number);
            Console.WriteLine(result);
        }

        private static int MultiplyEvenByOddDigits(int number)
        {
            int evenDigitsSum = SumEvenDigits(number);
            int oddDigitsSum = SumOddDigits(number);
            int result = evenDigitsSum * oddDigitsSum;

            return result;
        }

        private static int SumEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        private static int SumOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }
    }
}
