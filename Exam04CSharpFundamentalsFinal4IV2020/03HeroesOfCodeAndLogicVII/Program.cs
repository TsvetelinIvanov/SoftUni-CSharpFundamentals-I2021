using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HeroesOfCodeAndLogicVII
{
    class Program
    {
        private const int MaxHitPointsCount = 100;
        private const int MaxManaPointsCount = 200;

        static void Main(string[] args)
        {
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();
            int heroesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < heroesCount; i++)
            {
                string[] heroInfo = Console.ReadLine().Split();
                string heroName = heroInfo[0];
                int hitPointsCount = int.Parse(heroInfo[1]);
                if (hitPointsCount > MaxHitPointsCount)
                {
                    hitPointsCount = MaxHitPointsCount;
                }

                int manaPointsCount = int.Parse(heroInfo[2]);
                if (manaPointsCount > MaxManaPointsCount)
                {
                    manaPointsCount = MaxManaPointsCount;
                }

                heroes.Add(heroName, new int[] { hitPointsCount, manaPointsCount });
            }

            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "End")
            {
                string[] commandLine = commandLineString.Split(" - ");
                string command = commandLine[0];
                string[] arguments = commandLine.Skip(1).ToArray();
                switch (command)
                {
                    case "CastSpell":
                        CastSpell(heroes, arguments);
                        break;
                    case "TakeDamage":
                        TakeDamage(heroes, arguments);
                        break;
                    case "Recharge":
                        Recharge(heroes, arguments);
                        break;
                    case "Heal":
                        Heal(heroes, arguments);
                        break;
                    default:
                        throw new ArgumentException("Invalid command!");
                }
            }

            foreach (KeyValuePair<string, int[]> hero in heroes.OrderByDescending(h => h.Value[0]).ThenBy(h => h.Key))
            {
                Console.WriteLine($"{hero.Key}{Environment.NewLine}  HP: {hero.Value[0]}{Environment.NewLine}  MP: {hero.Value[1]}");
            }
        }

        private static void CastSpell(Dictionary<string, int[]> heroes, string[] arguments)
        {
            string heroName = arguments[0];
            int neededManaPointsCount = int.Parse(arguments[1]);
            string spellName = arguments[2];
            
            if (heroes[heroName][1] >= neededManaPointsCount)
            {
                heroes[heroName][1] -= neededManaPointsCount;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }            
        }

        private static void TakeDamage(Dictionary<string, int[]> heroes, string[] arguments)
        {
            string heroName = arguments[0];
            int damage = int.Parse(arguments[1]);
            string attackerName = arguments[2];
            heroes[heroName][0] -= damage;
            if (heroes[heroName][0] > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attackerName} and now has {heroes[heroName][0]} HP left!");
            }
            else
            {
                heroes.Remove(heroName);
                Console.WriteLine($"{heroName} has been killed by {attackerName}!");
            }
        }

        private static void Recharge(Dictionary<string, int[]> heroes, string[] arguments)
        {
            string heroName = arguments[0];
            int addedManaPointsCount = int.Parse(arguments[1]);
            if (heroes[heroName][1] + addedManaPointsCount > MaxManaPointsCount)
            {
                addedManaPointsCount = MaxManaPointsCount - heroes[heroName][1];
                heroes[heroName][1] = MaxManaPointsCount;                
            }
            else
            {
                heroes[heroName][1] += addedManaPointsCount;
            }

            Console.WriteLine($"{heroName} recharged for {addedManaPointsCount} MP!");
        }

        private static void Heal(Dictionary<string, int[]> heroes, string[] arguments)
        {
            string heroName = arguments[0];
            int addedHitPointsCount = int.Parse(arguments[1]);
            if (heroes[heroName][0] + addedHitPointsCount > MaxHitPointsCount)
            {
                addedHitPointsCount = MaxHitPointsCount - heroes[heroName][0];
                heroes[heroName][0] = MaxHitPointsCount;
            }
            else
            {
                heroes[heroName][0] += addedHitPointsCount;
            }

            Console.WriteLine($"{heroName} healed for {addedHitPointsCount} HP!");
        }
    }
}
