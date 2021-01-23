using System;

namespace _04PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleNumber = int.Parse(Console.ReadLine());
            PrintTriangle(triangleNumber);
        }

        private static void PrintTriangle(int triangleNumber)
        {
            for (int i = 1; i <= triangleNumber; i++)
            {
                PrintLine(i);
            }

            for (int i = triangleNumber - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int lineNumber)
        {
            for (int i = 1; i <= lineNumber; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
