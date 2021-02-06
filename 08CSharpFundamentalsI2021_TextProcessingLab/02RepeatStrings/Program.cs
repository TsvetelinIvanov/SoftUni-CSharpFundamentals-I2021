using System;

namespace _02RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string repeatedWord = string.Empty;
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    repeatedWord += word;
                }
            }

            Console.WriteLine(repeatedWord);
        }
    }
}