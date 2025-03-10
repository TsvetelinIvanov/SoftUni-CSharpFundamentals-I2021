using System;

namespace _08FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            
            long firstFactorial = GetFactorial(firstNumber);
            long secondFactorial = GetFactorial(secondNumber);
            
            decimal result = (decimal)firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");
        }

        private static long GetFactorial(int number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
