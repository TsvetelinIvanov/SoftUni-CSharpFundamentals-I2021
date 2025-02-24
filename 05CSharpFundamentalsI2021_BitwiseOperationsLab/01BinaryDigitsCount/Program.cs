using System;

namespace _01BinaryDigitsCount
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
            long binaryNumber = ConvertToBinary(number);
            while (binaryNumber > 0)
            {
                int currentBit = (int)(binaryNumber % 10);
                binaryNumber /= 10;
                if (currentBit == bit)
                {
                    bitsCount++;
                }
            }

            return bitsCount;
        }

        private static long ConvertToBinary(int number)
        {
            string reversedBinaryNumberString = string.Empty;
            while (number > 0)
            {
                int bit = number % 2;
                number /= 2;
                reversedBinaryNumberString += bit;
            }

            string binaryNumberString = string.Empty;
            for (int i = reversedBinaryNumberString.Length - 1; i >= 0; i--)
            {
                binaryNumberString += reversedBinaryNumberString[i];
            }

            long binaryNumber = long.Parse(binaryNumberString);

            return binaryNumber;
        }
    }
}
