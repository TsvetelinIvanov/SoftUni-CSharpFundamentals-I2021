using System;

namespace _05DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string digitsString = string.Empty;
            string lettersString = string.Empty;
            string otherCharactersString = string.Empty;
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digitsString += input[i];
                }
                else if (char.IsLetter(input[i]))
                {
                    lettersString += input[i];
                }
                else
                {
                    otherCharactersString += input[i];
                }
            }

            Console.WriteLine(digitsString);
            Console.WriteLine(lettersString);
            Console.WriteLine(otherCharactersString);
        }
    }
}