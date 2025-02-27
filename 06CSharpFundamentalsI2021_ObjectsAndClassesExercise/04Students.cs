using System;
using System.Linq;
using System.Collections.Generic;

namespace _04Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public double Grade { get; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentData = Console.ReadLine().Split();
                string firstName = studentData[0];
                string lastName = studentData[1];
                double grade = double.Parse(studentData[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students.OrderByDescending(s => s.Grade).ToList().ForEach(s => Console.WriteLine(s));
        }
    }
}
