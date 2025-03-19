using System;
using System.Linq;

namespace _03ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int[] warship = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int maxHealth = int.Parse(Console.ReadLine());
            
            bool haveWinner = false;
            string battleCommandsString;
            while ((battleCommandsString = Console.ReadLine()) != "Retire")
            {
                string[] battleCommands = battleCommandsString.Split();
                string battleCommand = battleCommands[0];
                switch (battleCommand)
                {
                    case "Fire":
                        int fireIndex = int.Parse(battleCommands[1]);
                        int fireDamage = int.Parse(battleCommands[2]);
                        if (IsInShip(warship, fireIndex))
                        {
                            haveWinner = Fire(warship, fireIndex, fireDamage);
                        }

                        break;
                    case "Defend":
                        int startIndex = int.Parse(battleCommands[1]);
                        int endIndex = int.Parse(battleCommands[2]);
                        int defendDamage = int.Parse(battleCommands[3]);
                        if (IsInShip(pirateShip, startIndex) && IsInShip(pirateShip, endIndex))
                        {
                            haveWinner = TakeDamage(pirateShip, startIndex, endIndex, defendDamage);
                        }

                        break;
                    case "Repair":
                        int repairIndex = int.Parse(battleCommands[1]);
                        int health = int.Parse(battleCommands[2]);
                        if (IsInShip(pirateShip, repairIndex))
                        {
                            Repair(pirateShip, repairIndex, health, maxHealth);
                        }

                        break;
                    case "Status":
                        Console.WriteLine(pirateShip.Count(s => s < (maxHealth * 0.2)) + " sections need repair.");
                        break;
                }

                if (haveWinner)
                {
                    break;
                }
            }

            if (!haveWinner)
            {
                Console.WriteLine("Pirate ship status: " + pirateShip.Sum());
                Console.WriteLine("Warship status: " + warship.Sum());
            }
        }

        private static bool IsInShip(int[] ship, int index)
        {
            return index >= 0 && index < ship.Length;
        }

        private static bool Fire(int[] warship, int index, int damage)
        {
            warship[index] -= damage;
            if (warship[index] <= 0)
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
                
                return true;
            }

            return false;
        }

        private static bool TakeDamage(int[] pirateShip, int startIndex, int endIndex, int damage)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                pirateShip[i] -= damage;
                if (pirateShip[i] <= 0)
                {
                    Console.WriteLine("You lost! The pirate ship has sunken.");
                    
                    return true;
                }
            }

            return false;
        }

        private static void Repair(int[] pirateShip, int index, int health, int maxHealth)
        {
            pirateShip[index] += health;
            if (pirateShip[index] > maxHealth)
            {
                pirateShip[index] = maxHealth;
            }
        }        
    }
}
