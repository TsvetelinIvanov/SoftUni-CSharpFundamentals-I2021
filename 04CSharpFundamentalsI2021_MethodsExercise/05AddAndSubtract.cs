using System;

namespace _05AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int sum = Sum(firstNumber, secondNumber);
            int result = Subtract(sum, thirdNumber);
            Console.WriteLine(result);
        }

        private static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
