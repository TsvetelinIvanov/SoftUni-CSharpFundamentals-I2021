using System;

namespace _07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int pouringsCount = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int waterInTank = 0;            
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
