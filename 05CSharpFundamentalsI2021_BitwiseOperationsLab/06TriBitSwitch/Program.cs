﻿using System;

namespace _06TriBitSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            
            int mask = 7 << position;
            int shiftedNumber = number ^ mask;
            Console.WriteLine(shiftedNumber);
        }
    }
}
