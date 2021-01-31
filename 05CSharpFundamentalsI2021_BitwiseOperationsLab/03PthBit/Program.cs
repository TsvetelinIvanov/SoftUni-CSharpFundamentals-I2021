using System;

namespace _03PthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int mask = 1;
            int currentNumber = number >> position;
            int bitAtPositionP = currentNumber & mask;
            Console.WriteLine(bitAtPositionP);
        }
    }
}