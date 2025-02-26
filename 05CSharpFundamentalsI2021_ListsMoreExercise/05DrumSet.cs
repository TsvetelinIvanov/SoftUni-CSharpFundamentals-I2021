using System;
using System.Linq;
using System.Collections.Generic;

namespace _05DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> originalDrums = new List<int>(drums);
            
            string hitPowerString;
            while ((hitPowerString = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(hitPowerString);
                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= hitPower;
                    if (drums[i] <= 0)
                    {
                        if (originalDrums[i] * 3 <= money)
                        {
                            money -= originalDrums[i] * 3;
                            drums[i] = originalDrums[i];
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            originalDrums.RemoveAt(i);
                            i--;
                        }
                    }                    
                }
            }

            Console.WriteLine(string.Join(" ", drums));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
