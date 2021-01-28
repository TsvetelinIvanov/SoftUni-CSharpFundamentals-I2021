using System;
using System.Collections.Generic;
using System.Linq;

namespace _05BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    numbers.RemoveAt(i);
                    i--;
                    for (int j = 0; j < bombPower; j++)
                    {
                        if (i < 0)
                        {
                            break;
                        }

                        numbers.RemoveAt(i);
                        i--;
                        
                    }

                    for (int j = 0; j < bombPower; j++)
                    {
                        i++;
                        if (i >= numbers.Count)
                        {
                            break;
                        }

                        numbers.RemoveAt(i);
                        i--;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
