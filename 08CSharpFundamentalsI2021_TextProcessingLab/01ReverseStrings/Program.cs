using System;

namespace _01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string reversed = ReverseString(input);
                Console.WriteLine(input + " = " + reversed);
            }
        }

        private static string ReverseString(string str)
        {
            string reversed = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }
    }
}