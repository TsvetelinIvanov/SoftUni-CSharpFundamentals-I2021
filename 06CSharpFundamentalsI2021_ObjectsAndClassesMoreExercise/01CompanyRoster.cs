using System;
using System.Linq;
using System.Collections.Generic;

namespace _01CompanyRoster
{
    class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        public string Name { get; }
        
        public decimal Salary { get; }
        
        public string Department { get; }
    }
    
    class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Employees = new List<Employee>();
        }

        public string Name { get; }

        public List<Employee> Employees { get; }

        public decimal AverageSalary => this.Employees.Average(e => e.Salary);        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            int employeesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < employeesCount; i++)
            {
                string[] employeeData = Console.ReadLine().Split();
                string name = employeeData[0];
                decimal salary = decimal.Parse(employeeData[1]);
                string departmentName = employeeData[2];
                Employee employee = new Employee(name, salary, departmentName);
                Department department = departments.FirstOrDefault(d => d.Name == departmentName);
                if (department == null)
                {
                    department = new Department(departmentName);
                    departments.Add(department);
                }

                department.Employees.Add(employee);
            }

            Department highestPayedDepartment = departments.OrderByDescending(d => d.AverageSalary).First();
            Console.WriteLine("Highest Average Salary: " + highestPayedDepartment.Name);
            highestPayedDepartment.Employees.OrderByDescending(e => e.Salary).ToList().ForEach(e => Console.WriteLine($"{e.Name} {e.Salary:f2}"));
        }
    }
}
