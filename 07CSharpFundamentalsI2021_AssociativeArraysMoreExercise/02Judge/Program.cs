using System;
using System.Linq;
using System.Collections.Generic;

namespace _02Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            ReadContestsRawData(contests, users);
            PrintContestsData(contests, users);
        }

        private static void ReadContestsRawData(Dictionary<string, Dictionary<string, int>> contests, Dictionary<string, Dictionary<string, int>> users)
        {
            string contestDataString;
            while ((contestDataString = Console.ReadLine()) != "no more time")
            {
                string[] contestData = contestDataString.Split(" -> ");
                string username = contestData[0];
                string contestName = contestData[1];
                int pointsCount = int.Parse(contestData[2]);
                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, new Dictionary<string, int>());
                }

                if (!contests[contestName].ContainsKey(username) || contests[contestName][username] < pointsCount)
                {
                    contests[contestName][username] = pointsCount;
                }

                if (!users.ContainsKey(username))
                {
                    users.Add(username, new Dictionary<string, int>());
                }

                if (!users[username].ContainsKey(contestName) || users[username][contestName] < pointsCount)
                {
                    users[username][contestName] = pointsCount;
                }
            }
        }

        private static void PrintContestsData(Dictionary<string, Dictionary<string, int>> contests, Dictionary<string, Dictionary<string, int>> users)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int participantNumber = 0;
                foreach (KeyValuePair<string, int> user in contest.Value.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
                {
                    Console.WriteLine($"{++participantNumber}. {user.Key} <::> {user.Value}");
                }
            }

            Console.WriteLine("Individual standings:");
            int userNumber = 0;
            foreach (KeyValuePair<string, Dictionary<string, int>> user in users.OrderByDescending(u => u.Value.Values.Sum()).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{++userNumber}. {user.Key} -> {user.Value.Values.Sum()}");
            }
        }
    }
}