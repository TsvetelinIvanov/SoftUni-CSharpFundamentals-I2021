using System;

namespace _01BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            decimal expectedPlunder = decimal.Parse(Console.ReadLine());
            
            decimal gainedPlunder = 0;
            for (int i = 1; i <= daysCount; i++)
            {
                gainedPlunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    gainedPlunder += dailyPlunder * 0.5m;
                }

                if (i % 5 == 0)
                {
                    gainedPlunder *= 0.7m;
                }
            }

            if (gainedPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {gainedPlunder:f2} plunder gained.");
            }
            else
            {
                decimal percentagePlunder = gainedPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentagePlunder:f2}% of the plunder.");
            }
        }
    }
}
