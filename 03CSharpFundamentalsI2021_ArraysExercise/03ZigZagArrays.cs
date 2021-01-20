using System;
using System.Linq;

namespace _03ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            int[] firstArray = new int[linesCount];
            int[] secondArray = new int[linesCount];
            for (int i = 0; i < linesCount; i++)
            {
                int[] currentNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstArray[i] = currentNumbers.First();
                    secondArray[i] = currentNumbers.Last();
                }
                else
                {
                    firstArray[i] = currentNumbers.Last();
                    secondArray[i] = currentNumbers.First();
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
