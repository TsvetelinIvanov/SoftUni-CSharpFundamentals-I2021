using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = Console.ReadLine().Split(", ").ToDictionary(p => p, p  => 0);
            string racePattern = @"[A-Za-z0-9]";
            Regex raceRegex = new Regex(racePattern);
            string raceDataString;
            while ((raceDataString = Console.ReadLine()) != "end of race")
            {
                MatchCollection raceDataMatches = raceRegex.Matches(raceDataString);
                AddDistanceToParticipant(raceDataMatches, participants);
            }

            string[] top3Participants = participants.OrderByDescending(p => p.Value).Take(3).Select(p => p.Key).ToArray();
            Console.WriteLine("1st place: " + top3Participants[0]);
            Console.WriteLine("2nd place: " + top3Participants[1]);
            Console.WriteLine("3rd place: " + top3Participants[2]);
        }

        private static void AddDistanceToParticipant(MatchCollection raceDataMatches, Dictionary<string, int> participants)
        {
            string participant = string.Empty;
            int distance = 0;
            foreach (Match raceDataMatch in raceDataMatches)
            {
                if (int.TryParse(raceDataMatch.Value, out int currentDistance))
                {
                    distance += currentDistance;
                }
                else
                {
                    participant += raceDataMatch.Value;
                }
            }

            if (participants.ContainsKey(participant))
            {
                participants[participant] += distance;
            }
        }
    }
}