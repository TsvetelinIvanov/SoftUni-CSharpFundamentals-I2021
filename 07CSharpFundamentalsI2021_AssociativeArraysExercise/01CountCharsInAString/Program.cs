using System;
using System.Collections.Generic;

namespace _01CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charactersCounts = new Dictionary<char, int>();
            string input = Console.ReadLine();
            foreach (char character in input)
            {
                if (character == ' ')
                {
                    continue;
                }

                if (!charactersCounts.ContainsKey(character))
                {
                    charactersCounts[character] = 0;
                }

                charactersCounts[character]++;
            }

            foreach (KeyValuePair<char, int> characterCount in charactersCounts)
            {
                Console.WriteLine(characterCount.Key + " -> " + characterCount.Value);
            }
        }
    }
}