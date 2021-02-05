using System;
using System.Linq;
using System.Collections.Generic;

namespace _07StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();
            int gradesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < gradesCount; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double>());
                }

                studentsGrades[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> student in studentsGrades.Where(s => s.Value.Average() >= 4.5).OrderByDescending(s => s.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}