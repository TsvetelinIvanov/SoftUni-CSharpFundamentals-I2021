using System;

namespace _09SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int daysCount = 0;
            int spaiceQuantity = 0;
            while (yield >= 100)
            {
                spaiceQuantity += yield;
                yield -= 10;
                daysCount++;
                spaiceQuantity -= 26;
            }

            spaiceQuantity -= 26;
            if (spaiceQuantity < 0)
            {
                spaiceQuantity = 0;
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(spaiceQuantity);
        }
    }
}
