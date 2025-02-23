using System;

namespace _03LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());
            
            double secondLineX1 = double.Parse(Console.ReadLine());
            double secondLineY1 = double.Parse(Console.ReadLine());
            double secondLineX2 = double.Parse(Console.ReadLine());
            double secondLineY2 = double.Parse(Console.ReadLine());
            
            CheckLengthAndPrintCoordinates(firstLineX1, firstLineY1, firstLineX2, firstLineY2, secondLineX1, secondLineY1, secondLineX2, secondLineY2);            
        }

        private static void CheckLengthAndPrintCoordinates(double firstLineX1, double firstLineY1, double firstLineX2, double firstLineY2, double secondLineX1, double secondLineY1, double secondLineX2, double secondLineY2)
        {            
            double firstLineLength = GetLineLength(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
            double secondLineLength = GetLineLength(secondLineX1, secondLineY1, secondLineX2, secondLineY2);           
            if (firstLineLength >= secondLineLength)
            {
                double centerDistanceFirstLinePoint1 = FindCenterDistance(firstLineX1, firstLineY1);
                double centerDistanceFirstLinePoint2 = FindCenterDistance(firstLineX2, firstLineY2);
                if (centerDistanceFirstLinePoint1 <= centerDistanceFirstLinePoint2)
                {
                    Console.WriteLine($"({firstLineX1}, {firstLineY1})({firstLineX2}, {firstLineY2})");
                }
                else
                {
                    Console.WriteLine($"({firstLineX2}, {firstLineY2})({firstLineX1}, {firstLineY1})");
                }
            }
            else
            {
                double centerDistanceSecondLinePoint1 = FindCenterDistance(secondLineX1, secondLineY1);
                double centerDistanceSecondLinePoint2 = FindCenterDistance(secondLineX2, secondLineY2);
                if (centerDistanceSecondLinePoint1 <= centerDistanceSecondLinePoint2)
                {
                    Console.WriteLine($"({secondLineX1}, {secondLineY1})({secondLineX2}, {secondLineY2})");
                }
                else
                {
                    Console.WriteLine($"({secondLineX2}, {secondLineY2})({secondLineX1}, {secondLineY1})");
                }
            }
        }

        private static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double deltaX = x1 - x2;
            double deltaY = y1 - y2;
            double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return length;
        }
       
        private static double FindCenterDistance(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
