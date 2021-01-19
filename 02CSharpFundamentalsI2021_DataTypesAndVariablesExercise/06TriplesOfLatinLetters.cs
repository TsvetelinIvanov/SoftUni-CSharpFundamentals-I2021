using System;

namespace _06TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int endLetter = int.Parse(Console.ReadLine());
            for (int i = 0; i < endLetter; i++)
            {
                for (int j = 0; j < endLetter; j++)
                {
                    for (int k = 0; k < endLetter; k++)
                    {
                        Console.WriteLine($"{(char)('a' + i)}{(char)('a' + j)}{(char)('a' + k)}");
                    }
                }
            }
        }
    }
}
