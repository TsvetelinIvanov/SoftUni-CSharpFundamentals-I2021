using System;

namespace _01RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random random = new Random();
            for (int oldPosition = 0; oldPosition < words.Length; oldPosition++)
            {
                int newPosition = random.Next(words.Length);
                string word = words[oldPosition];
                words[oldPosition] = words[newPosition];
                words[newPosition] = word;
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
