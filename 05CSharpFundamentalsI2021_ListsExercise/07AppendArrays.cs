using System;
using System.Collections.Generic;

namespace _07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split('|');
            List<string> numbers = new List<string>();
            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] array = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < array.Length; j++)
                {
                    numbers.Add(array[j]);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
