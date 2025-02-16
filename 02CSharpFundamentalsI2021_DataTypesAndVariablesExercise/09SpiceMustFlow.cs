using System;

namespace _09SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int daysCount = 0;
            int spiceQuantity = 0;
            while (yield >= 100)
            {
                spiceQuantity += yield;
                yield -= 10;
                daysCount++;
                spiceQuantity -= 26;
            }

            spiceQuantity -= 26;
            if (spiceQuantity < 0)
            {
                spiceQuantity = 0;
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(spiceQuantity);
        }
    }
}
