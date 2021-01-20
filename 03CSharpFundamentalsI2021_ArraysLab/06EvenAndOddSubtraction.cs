using System;
using System.Linq;

namespace _06EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenNumbersSum = numbers.Where(n => n % 2 == 0).Sum();
            int oddNumbersSum = numbers.Where(n => n % 2 != 0).Sum();
            int differenceEvetOdd = evenNumbersSum - oddNumbersSum; 
            Console.WriteLine(differenceEvetOdd);
        }
    }
}
