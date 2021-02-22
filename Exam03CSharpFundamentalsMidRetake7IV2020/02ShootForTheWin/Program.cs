using System;
using System.Linq;

namespace _02ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shotTargetsCount = 0;
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(input);
                if (!IsInTargets(targets, targetIndex) || targets[targetIndex] == -1)
                {
                    continue;
                }

                int targetValue = targets[targetIndex];
                targets[targetIndex] = -1;
                shotTargetsCount++;
                ProcessTargets(targets, targetValue);
            }

            Console.WriteLine($"Shot targets: {shotTargetsCount} -> {string.Join(" ", targets)}");
        }
        
        private static bool IsInTargets(int[] targets, int targetIndex)
        {
            return targetIndex >= 0 && targetIndex < targets.Length;
        }

        private static void ProcessTargets(int[] targets, int targetValue)
        {
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] == -1)
                {
                    //continue;
                }
                else if (targets[i] > targetValue)
                {
                    targets[i] -= targetValue;
                }
                else if (targets[i] <= targetValue)
                {
                    targets[i] += targetValue;
                }
            }
        }
    }
}