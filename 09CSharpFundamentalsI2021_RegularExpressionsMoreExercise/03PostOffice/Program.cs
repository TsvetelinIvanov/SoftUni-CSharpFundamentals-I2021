using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            
            string firstPart = input[0];
            string capitalLettersString = FindCapitalLetters(firstPart);            

            string secondPart = input[1];
            Dictionary<char, int> charsAndLengths = FindCharsAndLengths(secondPart, capitalLettersString);
            
            string thirdPart = input[2];
            string[] words = thirdPart.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            List<string> validWords = new List<string>();
            foreach (string word in words)
            {
                bool isValidWord = CheckWord(charsAndLengths, word);
                if (isValidWord)
                {
                    validWords.Add(word);
                }
            }

            for (int i = 0; i < capitalLettersString.Length; i++)
            {
                string validWord = validWords.First(vw => vw[0] == capitalLettersString[i]);
                Console.WriteLine(validWord);
            }
        }      

        private static string FindCapitalLetters(string @string)
        {
            Regex capitalLettersRegex = new Regex(@"([#$%*&])([A-Z]+)\1");
            Match capitalLettersMatch = capitalLettersRegex.Match(@string);
            string capitalLettersString = capitalLettersMatch.Groups[2].Value;

            return capitalLettersString;
        }

        private static Dictionary<char, int> FindCharsAndLengths(string @string, string capitalLettersString)
        {
            Dictionary<char, int> charsAndLengths = new Dictionary<char, int>();
            Regex asciiAndLengthRegex = new Regex(@"(\d{2}):(\d{2})");
            MatchCollection asciiAndLengthMatches = asciiAndLengthRegex.Matches(@string);
            foreach (Match asciiAndLengthMatch in asciiAndLengthMatches)
            {
                char character = (char)int.Parse(asciiAndLengthMatch.Groups[1].Value);
                if (capitalLettersString.Contains(character) && !charsAndLengths.ContainsKey(character))
                {
                    int length = int.Parse(asciiAndLengthMatch.Groups[2].Value) + 1;
                    charsAndLengths.Add(character, length);
                }
            }

            return charsAndLengths;
        }

        private static bool CheckWord(Dictionary<char, int> charsAndLengths, string word)
        {
            if (charsAndLengths.ContainsKey(word[0]) && word.Length == charsAndLengths[word[0]])
            {
                return true;
            }

            return false;
        }
    }
}
