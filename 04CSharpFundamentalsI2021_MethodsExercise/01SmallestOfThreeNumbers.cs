using System;

namespace _01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int minNumber = GetMinNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(minNumber);
        }

        private static int GetMinNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int minNumber = GetMinNumber(GetMinNumber(firstNumber, secondNumber), thirdNumber);

            return minNumber;
        }

        private static int GetMinNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber <= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
