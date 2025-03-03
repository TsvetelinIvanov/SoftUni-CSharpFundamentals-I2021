using System;
using System.Linq;
using System.Collections.Generic;

namespace _07StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsWithGrades = new Dictionary<string, List<double>>();
            
            int gradesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < gradesCount; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsWithGrades.ContainsKey(name))
                {
                    studentsWithGrades.Add(name, new List<double>());
                }

                studentsWithGrades[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> studentWithGrades in studentsWithGrades.Where(s => s.Value.Average() >= 4.5).OrderByDescending(s => s.Value.Average()))
            {
                Console.WriteLine($"{studentWithGrades.Key} -> {studentWithGrades.Value.Average():f2}");
            }
        }
    }
}
