using System;

namespace _05PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {

            char startCharacter = (char)int.Parse(Console.ReadLine());
            char endCharacter = (char)int.Parse(Console.ReadLine());
            for (char ch = startCharacter; ch <= endCharacter; ch++)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
        }
    }
}
