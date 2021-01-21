using System;
using System.Linq;

namespace _04FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = inputRow.Length / 4;
            int[] firstRow = inputRow.Take(k).Reverse().Concat(inputRow.Skip(3 * k).Reverse()).ToArray();
            int[] secondRow = inputRow.Skip(k).Take(2 * k).ToArray();
            int[] rowsSums = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                rowsSums[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", rowsSums));
        }
    }
}
