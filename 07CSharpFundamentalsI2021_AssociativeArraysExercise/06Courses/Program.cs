using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string courseName = input.Split(" : ").First();
                string studentName = input.Split(" : ").Last();
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);
            }

            foreach (KeyValuePair<string, List<string>> course in courses.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine(course.Key + ": " + course.Value.Count);
                Console.WriteLine("-- " + string.Join(Environment.NewLine + "-- ", course.Value.OrderBy(s => s)));
            }
        }
    }
}