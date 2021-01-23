using System;

namespace _07NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixNumber = int.Parse(Console.ReadLine());
            PrintMatrix(matrixNumber);
        }

        private static void PrintMatrix(int matrixNumber)
        {
            for (int i = 0; i < matrixNumber; i++)
            {
                PrintLine(matrixNumber);
            }
        }

        private static void PrintLine(int matrixNumber)
        {
            for (int i = 0; i < matrixNumber; i++)
            {
                Console.Write(matrixNumber + " ");
            }

            Console.WriteLine();
        }
    }
}
