using System;

namespace _01BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            
            double maxBonus = 0;
            int maxAttendancesCount = 0;
            for (int i = 0; i < studentsCount; i++)
            {
                int attendancesCount = int.Parse(Console.ReadLine());
                double bonus = (double)attendancesCount / lecturesCount * (5 + additionalBonus);
                if (bonus > maxBonus)
                {
                    maxBonus = bonus;
                    maxAttendancesCount = attendancesCount;
                }
            }

            maxBonus = Math.Ceiling(maxBonus);
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendancesCount} lectures.");
        }
    }
}
