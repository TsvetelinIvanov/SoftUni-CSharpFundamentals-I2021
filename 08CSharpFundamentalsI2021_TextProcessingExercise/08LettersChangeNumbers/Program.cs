using System;

namespace _08LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            decimal sum = 0;
            foreach (string @string in strings)
            {
                decimal number = TransformString(@string);
                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }

        private static decimal TransformString(string @string)
        {
            char firstLetter = @string[0];
            decimal number = decimal.Parse(@string.Substring(1, @string.Length - 2));
            char lastLetter = @string[@string.Length - 1];

            if (char.IsUpper(firstLetter))
            {
                number /= (1 + firstLetter - 'A');
            }
            else if (char.IsLower(firstLetter))
            {
                number *= (1 + firstLetter - 'a');
            }

            if (char.IsUpper(lastLetter))
            {
                number -= 1 + lastLetter - 'A';
            }
            else if (char.IsLower(lastLetter))
            {
                number += 1 + lastLetter - 'a';
            }

            return number;
        }
    }
}
