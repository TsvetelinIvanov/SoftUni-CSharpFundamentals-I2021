using System;

namespace _05PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {

            char startChar = (char)int.Parse(Console.ReadLine());
            char endChar = (char)int.Parse(Console.ReadLine());
            for (char ch = startChar; ch <= endChar; ch++)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
        }
    }
}
