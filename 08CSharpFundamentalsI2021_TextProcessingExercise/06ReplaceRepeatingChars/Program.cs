using System;
using System.Linq;

namespace _06ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    Console.Write(input[i]);
                }
            }

            if (input.Length > 0)
            {
                Console.Write(input[input.Length - 1]);
            }

            Console.WriteLine();
        }
    }
}