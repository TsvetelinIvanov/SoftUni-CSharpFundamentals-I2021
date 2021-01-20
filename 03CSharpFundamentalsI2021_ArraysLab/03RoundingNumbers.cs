using System;
using System.Linq;

namespace _03RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();            
            int[] roundedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0} => {1}", Convert.ToDecimal(numbers[i]), roundedNumbers[i]);
            }
        }
    }
}
