using System;

namespace _02CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string firstString = strings[0];
            string secondString = strings[1];
            
            int sum = MultilpyAndSumCharacters(firstString, secondString);
            Console.WriteLine(sum);
        }

        private static int MultilpyAndSumCharacters(string firstString, string secondString)
        {
            int sum = 0;
            int shorterStringLength = Math.Min(firstString.Length, secondString.Length);
            for (int i = 0; i < shorterStringLength; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            if (firstString.Length > secondString.Length)
            {
                for (int i = shorterStringLength; i < firstString.Length; i++)
                {
                    sum += firstString[i];
                }               
            }
            else if (secondString.Length > firstString.Length)
            {
                for (int i = shorterStringLength; i < secondString.Length; i++)
                {
                    sum += secondString[i];
                }
            }

            return sum;
        }
    }
}
