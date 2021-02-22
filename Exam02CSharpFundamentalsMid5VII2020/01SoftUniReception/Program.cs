using System;

namespace _01SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeStudentsPerHour = int.Parse(Console.ReadLine());
            int secondEmployeeStudentsPerHour = int.Parse(Console.ReadLine());
            int thirdEmployeeStudentsPerHour = int.Parse(Console.ReadLine());
            int employeesEfficiency = firstEmployeeStudentsPerHour + secondEmployeeStudentsPerHour + thirdEmployeeStudentsPerHour;
            int studentsCount = int.Parse(Console.ReadLine());
            int hoursCount = CalculateHours(employeesEfficiency, studentsCount);
            Console.WriteLine($"Time needed: {hoursCount}h.");
        }

        private static int CalculateHours(int employeesEfficiency, int studentsCount)
        {
            int hoursCount = 0;
            while (studentsCount > 0)
            {
                hoursCount++;
                if (hoursCount % 4 == 0)
                {
                    continue;
                }

                studentsCount -= employeesEfficiency;
            }

            return hoursCount;
        }
    }
}