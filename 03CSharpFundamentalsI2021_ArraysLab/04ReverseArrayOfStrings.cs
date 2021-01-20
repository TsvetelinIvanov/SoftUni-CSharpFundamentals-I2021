using System;

namespace _04ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();            
            for (int i = 0; i < strings.Length / 2; i++)
            {
                string currentString = strings[i];
                strings[i] = strings[strings.Length - 1 - i];
                strings[strings.Length - 1 - i] = currentString;
            }

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
