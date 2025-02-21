using System;
using System.Linq;

namespace _09GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            
            string maxValue = GetMax(type, firstValue, secondValue);
            Console.WriteLine(maxValue);          
        }

        private static string GetMax(string type, string firstValue, string secondValue)
        {
            string maxValue = string.Empty;
            switch (type)
            {
                case "int":
                    int firstNumber = int.Parse(firstValue);
                    int secondNumber = int.Parse(secondValue);
                    maxValue = GetMax(firstNumber, secondNumber);
                    break;
                case "char":
                    char firstCharacter = char.Parse(firstValue);
                    char secondCharacter = char.Parse(secondValue);
                    maxValue = GetMax(firstCharacter, secondCharacter);
                    break;
                case "string":
                    string[] strings = { firstValue, secondValue };
                    maxValue = strings.OrderByDescending(s => s).First();
                    break;
            }

            return maxValue;
        }

        private static string GetMax(int firstNumber, int secondNumber)
        {
            return Math.Max(firstNumber, secondNumber).ToString();
        }

        private static string GetMax(char firstCharacter, char secondCharacter)
        {
            char maxValue = (char)Math.Max(firstCharacter, secondCharacter);
            
            return maxValue.ToString();
        }
    }
}
