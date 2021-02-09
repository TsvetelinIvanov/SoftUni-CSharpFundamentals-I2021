using System;

namespace _01ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            char nameStartChar = '@';
            char nameEndChar = '|';
            char ageStartChar = '#';
            char ageEndChar = '*';
            for (int i = 0; i < linesCount; i++)
            {
                string line = Console.ReadLine();
                int nameStartIndex = line.IndexOf(nameStartChar) + 1;
                int nameEndIndex = line.IndexOf(nameEndChar);
                string name = line.Substring(nameStartIndex, nameEndIndex - nameStartIndex);

                int ageStartIndex = line.IndexOf(ageStartChar) + 1;
                int ageEndIndex = line.IndexOf(ageEndChar);
                string age = line.Substring(ageStartIndex, ageEndIndex - ageStartIndex);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}