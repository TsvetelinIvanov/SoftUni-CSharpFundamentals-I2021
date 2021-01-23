using System;

namespace _03CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char startCharacter = char.Parse(Console.ReadLine());
            char endCharacter = char.Parse(Console.ReadLine());
            PrintCharactersInRange(startCharacter, endCharacter);
        }

        private static void PrintCharactersInRange(char startCharacter, char endCharacter)
        {
            for (char ch = (char)(Math.Min(startCharacter, endCharacter) + 1); ch < Math.Max(startCharacter, endCharacter); ch++)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
        }
    }
}
