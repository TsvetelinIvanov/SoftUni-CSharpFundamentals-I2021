using System;

namespace _02CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintClosestToCenterPoint(x1, y1, x2, y2);
        }

        private static void PrintClosestToCenterPoint(double x1, double y1, double x2, double y2)
        {
            double xCenterDistance = FindCenterDistance(x1, y1);
            double yCenterDistance = FindCenterDistance(x2, y2);
            if (xCenterDistance <= yCenterDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double FindCenterDistance(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
