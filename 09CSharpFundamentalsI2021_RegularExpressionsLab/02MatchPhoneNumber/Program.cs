using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:^|\s)\+359( |-)2\1\d{3}\1\d{4}\b";
            string phonesImput = Console.ReadLine();
            MatchCollection validPhones = Regex.Matches(phonesImput, pattern);
            //string[] phones = validPhones.Cast<Match>().Select(m => m.Value.Trim()).ToArray();
            string[] phones = validPhones.Select(m => m.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}