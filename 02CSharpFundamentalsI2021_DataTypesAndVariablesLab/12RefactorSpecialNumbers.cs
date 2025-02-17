using System;

namespace _12RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());           
            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                int digitsSum = 0;
                while (i > 0)
                {
                    digitsSum += i % 10;
                    i = i / 10;
                }

                i = currentNumber;
                
                bool isSpecialNumber = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNumber);               
            }
        }
    }
}
