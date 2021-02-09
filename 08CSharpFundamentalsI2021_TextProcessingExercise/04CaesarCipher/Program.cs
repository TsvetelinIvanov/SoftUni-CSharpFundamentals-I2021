using System;
using System.Linq;

namespace _04CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encryptedText = string.Join("", text.Select(ch => (char)(ch + 3)));
            Console.WriteLine(encryptedText);
        }        
    }
}