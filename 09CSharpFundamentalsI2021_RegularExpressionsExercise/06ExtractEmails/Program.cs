using System;
using System.Text.RegularExpressions;

namespace _06ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailPattern = @"(^|\s)[A-Za-z0-9]([\w.-]*[A-Za-z0-9])?@[A-Za-z][A-Za-z.-]*\.[A-Za-z-]*[A-Za-z]\b";
            string input = Console.ReadLine();
            MatchCollection emailMatches = Regex.Matches(input, emailPattern);
            foreach (Match email in emailMatches)
            {
                Console.WriteLine(email.Value.TrimStart());
            }
        }
    }
}