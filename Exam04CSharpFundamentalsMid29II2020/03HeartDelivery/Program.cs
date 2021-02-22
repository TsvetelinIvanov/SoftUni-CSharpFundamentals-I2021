using System;
using System.Linq;

namespace _03HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            int cupidPosition = 0;
            string input;
            while ((input = Console.ReadLine()) != "Love!")
            {
                int jump = int.Parse(input.Split().Last());
                cupidPosition += jump;
                if (cupidPosition >= neighborhood.Length)
                {
                    cupidPosition = 0;
                }

                if (neighborhood[cupidPosition] > 0)
                {
                    neighborhood[cupidPosition] -= 2;
                    if (neighborhood[cupidPosition] == 0)
                    {
                        Console.WriteLine($"Place {cupidPosition} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {cupidPosition} already had Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {cupidPosition}.");
            int failedPlacesCount = neighborhood.Count(p => p > 0);
            if (failedPlacesCount > 0)
            {
                Console.WriteLine($"Cupid has failed {failedPlacesCount} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}