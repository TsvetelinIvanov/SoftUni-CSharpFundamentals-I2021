using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex destinationRegex = new Regex(@"(=|/)([A-Z][A-Za-z]{2,})\1");
            string destinationsRaw = Console.ReadLine();

            MatchCollection destinationMatches = destinationRegex.Matches(destinationsRaw);
            string[] destinations = destinationMatches.Select(dm => dm.Groups[2].Value).ToArray();

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}".Trim());
            Console.WriteLine("Travel Points: " + destinations.Sum(d => d.Length));
        }
    }
}