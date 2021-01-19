using System;

namespace _05DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int charactersCount = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 0; i < charactersCount; i++)
            {
                int asciiIndex = char.Parse(Console.ReadLine()) + key;
                message += (char)asciiIndex;
            }

            Console.WriteLine(message);
        }
    }
}
