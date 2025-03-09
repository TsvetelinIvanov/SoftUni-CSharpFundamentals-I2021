using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            Regex stringRegex = new Regex(@"(\D+)(\d+)");
            MatchCollection matches = stringRegex.Matches(input);
            
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Match match in matches)
            {
                string @string = match.Groups[1].Value;
                int repeatCount = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < repeatCount; i++)
                {
                    stringBuilder.Append(@string);
                }
            }

            int uniqueSymbolsCount = stringBuilder.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: " + uniqueSymbolsCount);
            Console.WriteLine(stringBuilder);
        }
    }
}
