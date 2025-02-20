using System;

namespace _10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= endNumber; i++)
            {
                bool isTopNumber = CheckIfIsTopNumber(i);
                if (isTopNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool CheckIfIsTopNumber(int number)
        {
            int digitsSum = 0;
            bool haveOddDigit = false;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                digitsSum += digit;
                if (digit % 2 != 0)
                {
                    haveOddDigit = true;
                }
            }

            return digitsSum % 8 == 0 && haveOddDigit;
        }
    }
}
