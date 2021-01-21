using System;

namespace _03RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNumber = int.Parse(Console.ReadLine());            
            int result = GetResultForFibonacciNumber(fibonacciNumber);
            Console.WriteLine(result);
        }

        private static int GetResultForFibonacciNumber(int fibonacciNumber)
        {
            int[] results = new int[fibonacciNumber];
            int result;
            if (results[fibonacciNumber - 1] != 0)
            {
                return results[fibonacciNumber - 1];
            }

            if (fibonacciNumber == 2)
            {
                results[fibonacciNumber - 1] = 1;

                return 1;
            }
            else if (fibonacciNumber == 1)
            {
                results[fibonacciNumber - 1] = 1;

                return 1;
            }

            result = GetResultForFibonacciNumber(fibonacciNumber - 1) + GetResultForFibonacciNumber(fibonacciNumber - 2);
            if (results[fibonacciNumber - 1] == 0)
            {
                results[fibonacciNumber - 1] = result;
            }

            return result;
        }
    }
}
