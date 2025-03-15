using System;

namespace _01CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int winsCount = 0;
            bool isWin = true;
            
            string input;
            while ((input = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(input);
                if (energy >= distance)
                {
                    energy -= distance;
                    winsCount++;
                }
                else
                {
                    isWin = false;
                    Console.WriteLine($"Not enough energy! Game ends with {winsCount} won battles and {energy} energy");

                    break;
                }

                if (winsCount % 3 == 0)
                {
                    energy += winsCount;
                }
            }

            if (isWin)
            {
                Console.WriteLine($"Won battles: {winsCount}. Energy left: {energy}");
            }
        }
    }
}
