using System;
using System.Linq;

namespace _02MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            const int InitialHealth = 100;
            const int InitialBitcoinsCount = 0;
            
            int health = InitialHealth;
            int bitcoinsCount = InitialBitcoinsCount;
            int visitedRoomsCount = 0;
            
            string[] rooms = Console.ReadLine().Split('|');
            foreach (string room in rooms)
            {
                visitedRoomsCount++;
                string item = room.Split().First();
                int pointsCount = int.Parse(room.Split().Last());
                if (item == "potion")
                {
                    if (health + pointsCount > InitialHealth)
                    {
                        pointsCount = InitialHealth - health;
                    }

                    health += pointsCount;
                    Console.WriteLine($"You healed for {pointsCount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (item == "chest")
                {
                    bitcoinsCount += pointsCount;
                    Console.WriteLine($"You found {pointsCount} bitcoins.");
                }
                else
                {
                    health -= pointsCount;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {item}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {item}.");
                        Console.WriteLine("Best room: " + visitedRoomsCount);

                        break;
                    }
                }
            }

            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine("Bitcoins: " + bitcoinsCount);
                Console.WriteLine("Health: " + health);
            }
        }
    }
}
