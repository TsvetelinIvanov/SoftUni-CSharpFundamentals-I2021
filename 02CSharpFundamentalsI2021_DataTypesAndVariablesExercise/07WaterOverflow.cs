using System;

namespace _07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int waterInTank = 0;
            int pouringsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < pouringsCount; i++)
            {
                int waterQuantity = int.Parse(Console.ReadLine());
                if (waterInTank + waterQuantity > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                waterInTank += waterQuantity;
            }

            Console.WriteLine(waterInTank);
        }
    }
}
