using System;
using System.Linq;
using System.Collections.Generic;

namespace _01Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            ReadInput(contests, users);
            PrintOutput(contests, users);            
        }

        private static void ReadInput(Dictionary<string, string> contests, Dictionary<string, Dictionary<string, int>> users)
        {
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string contest = input.Split(':').First();
                string password = input.Split(':').Last();
                contests.Add(contest, password);
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] submissionData = input.Split("=>");
                string contest = submissionData[0];
                string password = submissionData[1];
                string username = submissionData[2];
                int pointsCount = int.Parse(submissionData[3]);
                if (!contests.ContainsKey(contest) || contests[contest] != password)
                {
                    continue;
                }

                if (!users.ContainsKey(username))
                {
                    users.Add(username, new Dictionary<string, int>());
                }

                if (!users[username].ContainsKey(contest) || users[username][contest] < pointsCount)
                {
                    users[username][contest] = pointsCount;
                }
            }
        }

        private static void PrintOutput(Dictionary<string, string> contests, Dictionary<string, Dictionary<string, int>> users)
        {
            KeyValuePair<string, Dictionary<string, int>> bestUser = users.OrderByDescending(u => u.Value.Values.Sum()).First();
            Console.WriteLine($"Best candidate is {bestUser.Key} with total {bestUser.Value.Sum(contest => contest.Value)} points.");
            Console.WriteLine("Ranking: ");
            foreach (KeyValuePair<string, Dictionary<string, int>> user in users.OrderBy(u => u.Key))
            {
                Console.WriteLine(user.Key);
                foreach (KeyValuePair<string, int> contest in user.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}