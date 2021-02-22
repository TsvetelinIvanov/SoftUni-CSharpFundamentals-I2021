using System;

namespace _01NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeesEfficiency = 0;
            for (int i = 0; i < 3; i++)
            {
                employeesEfficiency += int.Parse(Console.ReadLine());
            }

            int peopleCount = int.Parse(Console.ReadLine());
            int neededTime = 0;
            while (peopleCount > 0)
            {
                neededTime++;
                if (neededTime % 4 == 0)
                {
                    continue;
                }

                peopleCount -= employeesEfficiency;
            }

            Console.WriteLine($"Time needed: {neededTime}h.");
        }
    }
}