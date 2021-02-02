using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Select(w => w.ToLower()).ToArray();
            Dictionary<string, int> wordsCounts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordsCounts.ContainsKey(word))
                {
                    wordsCounts[word]++;
                }
                else
                {
                    wordsCounts.Add(word, 1);
                }
            }

            foreach (string word in wordsCounts.Where(wc => wc.Value % 2 != 0).Select(wc => wc.Key))
            {
                Console.Write(word + " ");
            }
        }
    }
}