using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pairRegex = new Regex(@"(@|#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1");
            string input = Console.ReadLine();
            MatchCollection pairMatches = pairRegex.Matches(input);
            if (pairMatches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");

                return;
            }

            Console.WriteLine(pairMatches.Count + " word pairs found!");

            List<string> mirrorWords = FindMirrorWords(pairMatches);
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }

        private static List<string> FindMirrorWords(MatchCollection pairMatches)
        {
            List<string> mirrorWords = new List<string>();
            foreach (Match pairMatch in pairMatches)
            {
                string firstWord = pairMatch.Groups[2].Value;
                string secondWord = pairMatch.Groups[3].Value;
                if (AreMirrorWords(firstWord, secondWord))
                {
                    string mirrorPair = firstWord + " <=> " + secondWord;
                    mirrorWords.Add(mirrorPair);
                }
            }

            return mirrorWords;
        }

        private static bool AreMirrorWords(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
            {
                return false;
            }

            for (int i = 0; i < firstWord.Length; i++)
            {
                if (firstWord[i] != secondWord[secondWord.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}