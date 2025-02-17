using System;

namespace _09CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());
            char thirdCharacter = char.Parse(Console.ReadLine());
            
            string concatenatedString = string.Empty + firstCharacter + secondCharacter + thirdCharacter;
            Console.WriteLine(concatenatedString);
        }
    }
}
