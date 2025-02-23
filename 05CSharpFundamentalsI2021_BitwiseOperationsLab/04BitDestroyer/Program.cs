using System;

namespace _04BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            
            int mask = ~(1 << position);
            int destroyedNumber = number & mask;            
            Console.WriteLine(destroyedNumber);            
        }
    }
}
