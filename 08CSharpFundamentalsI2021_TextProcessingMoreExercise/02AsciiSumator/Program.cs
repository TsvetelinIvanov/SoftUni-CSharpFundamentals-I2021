using System;

namespace _02AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char startCharacter = char.Parse(Console.ReadLine());
            char endCharacter = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int charactersSum = 0;
            foreach (char ch in input)
            {
                if (ch > startCharacter && ch < endCharacter)
                {
                    charactersSum += ch;
                }
            }

            Console.WriteLine(charactersSum);
        }
    }
}
