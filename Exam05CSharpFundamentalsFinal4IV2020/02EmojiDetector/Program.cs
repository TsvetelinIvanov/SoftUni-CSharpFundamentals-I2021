using System;
using System.Text.RegularExpressions;

namespace _02EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {            
            string input = Console.ReadLine();           
            long threshold = CalculateThreshold(input);
            Console.WriteLine("Cool threshold: " + threshold);

            Regex emojiRegex = new Regex(@"(::|\*\*)([A-Z][a-z]{2,})\1");
            MatchCollection emojisMatches = emojiRegex.Matches(input);
            Console.WriteLine(emojisMatches.Count + " emojis found in the text. The cool ones are:");
            foreach (Match emojiMatch in emojisMatches)
            {
                if (IsCoolEmoji(emojiMatch.Groups[2].Value, threshold))
                {
                    Console.WriteLine(emojiMatch.Value);
                }
            }
        }        

        private static long CalculateThreshold(string input)
        {
            long threshold = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    threshold *= byte.Parse(input[i].ToString());
                }
            }

            return threshold;
        }

        private static bool IsCoolEmoji(string value, long threshold)
        {
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                sum += value[i];
            }

            return sum > threshold;
        }
    }
}