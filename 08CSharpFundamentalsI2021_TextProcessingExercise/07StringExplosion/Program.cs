using System;
using System.Text;

namespace _07StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            int explosionStrength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    output += input[i];
                    explosionStrength += int.Parse(input[i + 1].ToString());
                    continue;
                }

                if (explosionStrength > 0)
                {
                    explosionStrength--;
                    continue;
                }

                output += input[i];
            }

            Console.WriteLine(output);
        }
    }
}