using System;

namespace _04BitDestroyerModified
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int bit = int.Parse(Console.ReadLine());            
            int destroyedNumber = number & ~(1 << position) | (bit << position);
            Console.WriteLine(destroyedNumber);
        }
    }
}