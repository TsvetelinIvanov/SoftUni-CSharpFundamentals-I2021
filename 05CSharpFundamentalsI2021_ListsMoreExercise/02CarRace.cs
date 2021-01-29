using System;
using System.Collections.Generic;
using System.Linq;

namespace _02CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> track = Console.ReadLine().Split().Select(double.Parse).ToList();
            double leftCarTime = 0;
            double rightCarTime = 0;
            for (int i = 0; i < track.Count / 2; i++)
            {
                leftCarTime += track[i];
                if (track[i] == 0)
                {
                    leftCarTime *= 0.8;
                }

                rightCarTime += track[track.Count - 1 - i];
                if (track[track.Count - 1 - i] == 0)
                {
                    rightCarTime *= 0.8;
                }
            }

            if (leftCarTime < rightCarTime)
            {
                Console.WriteLine("The winner is left with total time: " + leftCarTime);
            }
            else if (rightCarTime < leftCarTime)
            {
                Console.WriteLine("The winner is right with total time: " + rightCarTime);
            }
        }
    }
}
