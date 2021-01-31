using System;
using System.Linq;
using System.Collections.Generic;

namespace _05StudentsII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string studentDataString;
            while ((studentDataString = Console.ReadLine()) != "end")
            {
                string[] studentData = studentDataString.Split();
                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string homeTown = studentData[3];
                if (students.Any(s => s.FirtName == firstName && s.LastName == lastName))
                {
                    Student student = students.First(s => s.FirtName == firstName && s.LastName == lastName);
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirtName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    };
                    students.Add(student);
                }                
            }

            string town = Console.ReadLine();
            students.Where(s => s.HomeTown == town).ToList().ForEach(s => Console.WriteLine($"{s.FirtName} {s.LastName} is {s.Age} years old."));
        }

        class Student
        {
            public string FirtName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
