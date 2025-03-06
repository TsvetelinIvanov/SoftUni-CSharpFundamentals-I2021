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

        private static string ReverseString(string stringForReversing)
        {
            string reversed = string.Empty;
            for (int i = stringForReversing.Length - 1; i >= 0; i--)
            {
                reversed += stringForReversing[i];
            }

            return reversed;
        }
    }
}
