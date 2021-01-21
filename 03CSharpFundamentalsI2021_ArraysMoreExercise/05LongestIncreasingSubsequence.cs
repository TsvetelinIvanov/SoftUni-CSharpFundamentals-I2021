using System;
using System.Linq;

namespace _05LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int[] lengths = new int[integers.Length];
            int[] previousIndexes = new int[integers.Length];
            int maxLength = 0;
            int previousIndex = -1;
            for (int i = 0; i < integers.Length; i++)
            {
                lengths[i] = 1;
                previousIndexes[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (integers[j] < integers[i] && lengths[j] >= lengths[i])
                    {
                        lengths[i] = 1 + lengths[j];
                        previousIndexes[i] = j;
                    }
                }

                if (lengths[i] > maxLength)
                {
                    maxLength = lengths[i];
                    previousIndex = i;
                }
            }

            int[] lis = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = integers[previousIndex];
                previousIndex = previousIndexes[previousIndex];                
            }

            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
