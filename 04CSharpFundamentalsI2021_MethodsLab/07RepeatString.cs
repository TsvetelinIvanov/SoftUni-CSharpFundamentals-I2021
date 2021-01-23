using System;
using System.Text;

namespace _07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string outputString = RepeatString(inputString, count);
            Console.WriteLine(outputString);
        }

        private static string RepeatString(string str, int timesOfRepeating)
        {
            StringBuilder outputBuilder = new StringBuilder();
            for (int i = 0; i < timesOfRepeating; i++)
            {
                outputBuilder.Append(str);
            }

            return outputBuilder.ToString();
        }
    }
}
