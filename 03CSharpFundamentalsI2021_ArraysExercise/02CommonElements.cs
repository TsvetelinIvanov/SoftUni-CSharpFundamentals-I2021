using System;
using System.Linq;

namespace _02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            foreach (string item in secondArray)
            {
                if (firstArray.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
