using System;
using System.Linq;
using System.Collections.Generic;

namespace _03MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string shootCommandsString;
            while ((shootCommandsString = Console.ReadLine()) != "End")
            {
                string[] shootCommands = shootCommandsString.Split();
                string shootCommand = shootCommands[0];
                int targetIndex = int.Parse(shootCommands[1]);
                switch (shootCommand)
                {
                    case "Shoot":
                        int power = int.Parse(shootCommands[2]);
                        ShootTarget(targets, targetIndex, power);
                        break;
                    case "Add":
                        int value = int.Parse(shootCommands[2]);
                        AddTarget(targets, targetIndex, value);
                        break;
                    case "Strike":
                        int radius = int.Parse(shootCommands[2]);
                        StrikeTarget(targets, targetIndex, radius);
                        break;
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        private static void ShootTarget(List<int> targets, int targetIndex, int power)
        {
            if (!IsInTargets(targets, targetIndex))
            {
                return;
            }

            targets[targetIndex] -= power;
            if (targets[targetIndex] <= 0)
            {
                targets.RemoveAt(targetIndex);
            }
        }

        private static void AddTarget(List<int> targets, int targetIndex, int value)
        {
            if (!IsInTargets(targets, targetIndex))
            {
                Console.WriteLine("Invalid placement!");

                return;
            }
            
            targets.Insert(targetIndex, value);            
        }

        private static void StrikeTarget(List<int> targets, int targetIndex, int radius)
        {
            int startIndex = targetIndex - radius;
            int endIndex = targetIndex + radius;

            if (!IsInTargets(targets, startIndex) || !IsInTargets(targets, endIndex))
            {
                Console.WriteLine("Strike missed!");

                return;
            }

            targets.RemoveRange(startIndex, endIndex - startIndex + 1);
        }

        private static bool IsInTargets(List<int> targets, int targetIndex)
        {
            return targetIndex >= 0 && targetIndex < targets.Count;
        }
    }
}