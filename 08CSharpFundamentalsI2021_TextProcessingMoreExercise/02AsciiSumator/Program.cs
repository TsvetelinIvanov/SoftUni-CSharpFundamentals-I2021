using System;

namespace _02AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int charSum = 0;
            foreach (char ch in str)
            {
                if (ch > startChar && ch < endChar)
                {
                    charSum += ch;
                }
            }

            Console.WriteLine(charSum);
        }
    }
}