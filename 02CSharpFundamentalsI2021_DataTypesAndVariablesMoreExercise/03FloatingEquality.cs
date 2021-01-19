using System;

namespace _03FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            Console.WriteLine(Math.Abs(Math.Abs(firstNumber) - Math.Abs(secondNumber)) < eps);
        }
    }
}
