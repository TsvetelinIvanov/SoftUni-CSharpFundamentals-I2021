using System;
using System.Collections.Generic;
using System.Linq;

namespace _07OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; }

        public string Id { get; }

        public int Age { get; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string personDataString;
            while ((personDataString = Console.ReadLine()) != "End")
            {
                string[] personData = personDataString.Split();
                string name = personData[0];
                string id = personData[1];
                int age = int.Parse(personData[2]);
                Person person = new Person(name, id, age);
                people.Add(person);
            }

            people = people.OrderBy(p => p.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
