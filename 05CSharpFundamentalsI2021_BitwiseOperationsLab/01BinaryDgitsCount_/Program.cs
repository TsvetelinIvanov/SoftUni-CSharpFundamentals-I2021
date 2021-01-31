using System;

namespace _01BinaryDgitsCount_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bit = int.Parse(Console.ReadLine());
            int bitsCount = ReadBitsCount(number, bit);
            Console.WriteLine(bitsCount);
        }

        private static int ReadBitsCount(int number, int bit)
        {
            int bitsCount = 0;            
            int mask = 1;
            int currentNumber = number;
            int position = 0;
            while (currentNumber > 1)
            {
                int currentBit = (number >> position) & mask;
                currentNumber = number >> position;
                position++;
                if (currentBit == bit)
                {
                    bitsCount++;
                }
            }            

            return bitsCount;
        }        
    }
}