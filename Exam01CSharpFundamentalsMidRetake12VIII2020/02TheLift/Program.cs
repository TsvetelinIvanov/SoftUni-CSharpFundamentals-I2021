using System;
using System.Linq;

namespace _02TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPlacesCount = 4;
            int peopleCount = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < lift.Length; i++)
            {
                int freePlacesCount = maxPlacesCount - lift[i];
                if (peopleCount >= freePlacesCount)
                {
                    peopleCount -= freePlacesCount;
                    lift[i] = maxPlacesCount;
                }
                else
                {
                    freePlacesCount -= peopleCount;
                    lift[i] = maxPlacesCount - freePlacesCount;
                    peopleCount = 0;
                }

                if (peopleCount == 0)
                {
                    break;
                }
            }
            

            if (peopleCount == 0 && lift.Any(w => w < maxPlacesCount))
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (peopleCount > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
            }

            Console.WriteLine(string.Join(" ", lift));
        }
    }
}