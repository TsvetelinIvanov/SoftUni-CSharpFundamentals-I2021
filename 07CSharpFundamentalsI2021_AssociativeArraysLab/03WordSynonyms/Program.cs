using System;
using System.Linq;
using System.Collections.Generic;

namespace _03WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            int synonymsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < synonymsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }

                synonyms[word].Add(synonym);
            }

            foreach (KeyValuePair<string, List<string>> wordAndSynonyms in synonyms)
            {
                Console.WriteLine(wordAndSynonyms.Key + " - " + string.Join(", ", wordAndSynonyms.Value));
            }
        }
    }
}