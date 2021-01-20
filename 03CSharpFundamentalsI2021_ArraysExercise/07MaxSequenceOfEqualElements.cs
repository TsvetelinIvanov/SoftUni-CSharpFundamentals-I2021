using System;
using System.Linq;

namespace _07MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();            
            int maxSequenceLength = 1;
            int maxSequenceNumber = numbers[0];
            int sequenceLength = 1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {                
                if (numbers[i] == numbers[i + 1])
                {
                    sequenceLength++;
                }
                else
                {
                    sequenceLength = 1;
                }

                if (sequenceLength > maxSequenceLength)
                {
                    maxSequenceLength = sequenceLength;
                    maxSequenceNumber = numbers[i];
                }
            }

            for (int i = 0; i < maxSequenceLength; i++)
            {
                Console.Write(maxSequenceNumber + " ");
            }

            Console.WriteLine();
        }
    }
}
