using System;
using System.Linq;

namespace _02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vowelsCount = CountVowels(word);
            Console.WriteLine(vowelsCount);
        }

        private static int CountVowels(string word)
        {
            char[] vowels = "AaEeIiOoUu".ToCharArray();
            int vowelsCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
