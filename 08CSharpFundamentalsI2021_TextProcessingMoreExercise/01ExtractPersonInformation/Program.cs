using System;

namespace _01ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            char nameStartCharacter = '@';
            char nameEndCharacter = '|';
            char ageStartCharacter = '#';
            char ageEndCharacter = '*';
            for (int i = 0; i < linesCount; i++)
            {
                string line = Console.ReadLine();
                int nameStartIndex = line.IndexOf(nameStartCharacter) + 1;
                int nameEndIndex = line.IndexOf(nameEndCharacter);
                string name = line.Substring(nameStartIndex, nameEndIndex - nameStartIndex);

                int ageStartIndex = line.IndexOf(ageStartCharacter) + 1;
                int ageEndIndex = line.IndexOf(ageEndCharacter);
                string age = line.Substring(ageStartIndex, ageEndIndex - ageStartIndex);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
