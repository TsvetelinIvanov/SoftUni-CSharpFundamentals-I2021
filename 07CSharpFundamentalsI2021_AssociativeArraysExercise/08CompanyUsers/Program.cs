using System;
using System.Linq;
using System.Collections.Generic;

namespace _08CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string companyName = input.Split(" -> ").First();
                string employeeId = input.Split(" -> ").Last();
                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new HashSet<string>();
                }

                companies[companyName].Add(employeeId);
            }

            foreach (KeyValuePair<string, HashSet<string>> company in companies.OrderBy(c => c.Key))
            {
                Console.WriteLine(company.Key);
                Console.WriteLine("-- " + string.Join(Environment.NewLine + "-- ", company.Value));
            }
        }
    }
}