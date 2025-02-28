using System;
using System.Linq;
using System.Collections.Generic;

namespace _04Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirtName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirtName { get; }
        
        public string LastName { get; }
        
        public int Age { get; }
        
        public string HomeTown { get; }
    }
    
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
                
                Student student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);
            }

            string town = Console.ReadLine();
            students.Where(s => s.HomeTown == town).ToList().ForEach(s => Console.WriteLine($"{s.FirtName} {s.LastName} is {s.Age} years old."));
        }
    }
}
