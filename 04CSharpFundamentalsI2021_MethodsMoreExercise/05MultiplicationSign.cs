using System;

namespace _05MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            
            string productSign = CheckProductSign(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(productSign);
        }

        private static string CheckProductSign(int firstNumber, int secondNumber, int thirdNumber)
        {
            string productSign = string.Empty;
            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                productSign = "zero";
            }
            else if (firstNumber < 0)
            {
                if (secondNumber < 0)
                {
                    if (thirdNumber < 0)
                    {
                        productSign = "negative";
                    }
                    else if (thirdNumber > 0)
                    {
                        productSign = "positive";
                    }
                }
                else if (secondNumber > 0)
                {
                    if (thirdNumber > 0)
                    {
                        productSign = "negative";
                    }
                    else if (thirdNumber < 0)
                    {
                        productSign = "positive";
                    }
                }
            }
            else if (firstNumber > 0)
            {
                if (secondNumber < 0)
                {
                    if (thirdNumber > 0)
                    {
                        productSign = "negative";
                    }
                    else if (thirdNumber < 0)
                    {
                        productSign = "positive";
                    }
                }
                else if (secondNumber > 0)
                {
                    if (thirdNumber < 0)
                    {
                        productSign = "negative";
                    }
                    else if (thirdNumber > 0)
                    {
                        productSign = "positive";
                    }
                }
            }

            return productSign;
        }
    }
}
