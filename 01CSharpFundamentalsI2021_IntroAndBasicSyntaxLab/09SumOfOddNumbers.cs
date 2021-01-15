using System;

namespace _09SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumbersCount = int.Parse(Console.ReadLine());
            int oddNumbersSum = 0;
            for (int i = 1; i <= oddNumbersCount; i++)
            {
                int currentOddNumber = i * 2 - 1;
                oddNumbersSum += currentOddNumber;
                Console.WriteLine(currentOddNumber);                
            }

            Console.WriteLine("Sum: " + oddNumbersSum);
        }
    }
}
