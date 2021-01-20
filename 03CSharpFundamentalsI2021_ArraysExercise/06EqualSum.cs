using System;
using System.Linq;

namespace _06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int leftSum = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                int rightSum = 0;
                for (int j = i + 1; j < integers.Length; j++)
                {
                    rightSum += integers[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum += integers[i];
            }

            Console.WriteLine("no");
        }
    }
}
