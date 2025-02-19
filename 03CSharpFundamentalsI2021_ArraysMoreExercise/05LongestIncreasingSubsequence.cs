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
            int[] previousIndices = new int[integers.Length];
            int maxLength = 0;
            int previousIndex = -1;
            for (int i = 0; i < integers.Length; i++)
            {
                lengths[i] = 1;
                previousIndices[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (integers[j] < integers[i] && lengths[j] >= lengths[i])
                    {
                        lengths[i] = 1 + lengths[j];
                        previousIndices[i] = j;
                    }
                }

                if (lengths[i] > maxLength)
                {
                    maxLength = lengths[i];
                    previousIndex = i;
                }
            }

            int[] longestIncreasingSubsequence = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                longestIncreasingSubsequence[i] = integers[previousIndex];
                previousIndex = previousIndices[previousIndex];                
            }

            Array.Reverse(longestIncreasingSubsequence);
            Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));
        }
    }
}
