using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<char> inputCharacters = Console.ReadLine().ToCharArray().ToList();
            string message = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                int index = GetIndexFromDigits(numbers[i]) % inputCharacters.Count;
                message += inputCharacters[index];
                inputCharacters.RemoveAt(index);
            }

            Console.WriteLine(message);
        }

        private static int GetIndexFromDigits(int number)
        {
            int digitsSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                digitsSum += digit;
            }

            return digitsSum;
        }
    }
}
