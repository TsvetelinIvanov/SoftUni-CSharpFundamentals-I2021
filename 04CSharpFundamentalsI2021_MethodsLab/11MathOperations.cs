using System;

namespace _11MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstOperand = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondOperand = double.Parse(Console.ReadLine());
            double result = Calculate(firstOperand, secondOperand, @operator);
            Console.WriteLine(result);
        }

        private static double Calculate(double firstOperand, double secondOperand, string @operator)
        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    break;
                case "/":
                    result = firstOperand / secondOperand;
                    break;
            }

            return Math.Round(result, 2);
        }
    }
}
