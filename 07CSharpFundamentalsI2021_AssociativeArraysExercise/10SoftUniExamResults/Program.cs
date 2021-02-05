using System;
using System.Linq;
using System.Collections.Generic;

namespace _10SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {            
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();
            string submission;
            while ((submission = Console.ReadLine()) != "exam finished")
            {
                string[] submissionData = submission.Split('-');
                string username = submissionData[0];
                if (submissionData.Length == 3 && submissionData[1] != "banned")
                {
                    string language = submissionData[1];
                    if (!languages.ContainsKey(language))
                    {
                        languages[language] = 0;
                    }

                    languages[language]++;

                    int pointsCount = int.Parse(submissionData[2]);
                    if (!results.ContainsKey(username))
                    {
                        results[username] = pointsCount;
                    }
                    else if (results[username] < pointsCount)
                    {
                        results[username] = pointsCount;
                    }
                }
                else if (submissionData.Length == 2 && submissionData[1] == "banned")
                {
                    results.Remove(username);
                }
            }

            Console.WriteLine("Results:");
            foreach (KeyValuePair<string, int> result in results.OrderByDescending(r => r.Value).ThenBy(r => r.Key))
            {
                Console.WriteLine(result.Key + " | " + result.Value);
            }

            Console.WriteLine("Submissions:");
            foreach (KeyValuePair<string, int> language in languages.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine(language.Key + " - " + language.Value);
            }
        }
    }
}