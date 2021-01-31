using System;

namespace _02BitAtPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = 1;            
            int mask = 1;
            int currentNumber = number >> position;
            int bitAtPosition1 = currentNumber & mask;
            Console.WriteLine(bitAtPosition1);
        }
    }
}