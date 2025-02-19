using System;
using System.Linq;

namespace _04FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int fourth = inputArray.Length / 4;
            
            int[] firstRow = inputArray.Take(fourth).Reverse().Concat(inputArray.Skip(3 * fourth).Reverse()).ToArray();
            int[] secondRow = inputRow.Skip(fourth).Take(2 * fourth).ToArray();
            
            int[] rowsSums = new int[2 * fourth];
            for (int i = 0; i < 2 * fourth; i++)
            {
                rowsSums[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", rowsSums));
        }
    }
}
