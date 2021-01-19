using System;
using System.Linq;

namespace _02FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < linesCount; i++)
            {
                string line = Console.ReadLine();
                int index = 0;
                string leftNumberString = string.Empty;                
                while (line[index] != ' ')
                {
                    leftNumberString += line[index];
                    index++;
                }

                string rightNumberString = string.Empty;
                for (int j = index + 1; j < line.Length; j++)
                {
                    rightNumberString += line[j];
                }

                long leftNumber = long.Parse(leftNumberString);
                long rightNumber = long.Parse(rightNumberString);
                long digitsSum = 0;
                if (leftNumber > rightNumber)
                {
                    leftNumber = Math.Abs(leftNumber);
                    while (leftNumber > 0)
                    {
                        digitsSum += leftNumber % 10;
                        leftNumber /= 10;
                    }
                }
                else
                {
                    rightNumber = Math.Abs(rightNumber);
                    while (rightNumber > 0)
                    {
                        digitsSum += rightNumber % 10;
                        rightNumber /= 10;
                    }
                }

                Console.WriteLine(digitsSum);
            }
        }
    }
}
