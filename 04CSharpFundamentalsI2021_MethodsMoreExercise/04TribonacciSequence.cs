using System;

namespace _04TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            if (numbersCount == 1)
            {
                Console.WriteLine(1);
            }
            else if (numbersCount == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (numbersCount == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                Console.Write("1 1 2 ");
                PrintTribonacciNumbers(numbersCount);
            }
        }

        private static void PrintTribonacciNumbers(int numbersCount)
        {
            int firstTribonacciNumber = 1;
            int secondTribonacciNumber = 1;
            int thirdTribonacciNumber = 2;
            for (int i = 0; i < numbersCount - 3; i++)
            {
                int tribonacciNumber = firstTribonacciNumber + secondTribonacciNumber + thirdTribonacciNumber;
                firstTribonacciNumber = secondTribonacciNumber;
                secondTribonacciNumber = thirdTribonacciNumber;
                thirdTribonacciNumber = tribonacciNumber;
                Console.Write(tribonacciNumber + " ");
            }

            Console.WriteLine();
        }
    }
}
