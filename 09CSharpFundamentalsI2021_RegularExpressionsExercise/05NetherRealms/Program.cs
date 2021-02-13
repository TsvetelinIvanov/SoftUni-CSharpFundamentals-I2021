using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demonNames = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, decimal[]> demons = new Dictionary<string, decimal[]>();
            foreach (string demonName in demonNames)
            {
                demons[demonName] = new decimal[2];

                decimal health = ExtractHealth(demonName);
                decimal damage = ExtractDamage(demonName);

                demons[demonName][0] = health;
                demons[demonName][1] = damage;
            }

            foreach (KeyValuePair<string, decimal[]> demon in demons.OrderBy(d => d.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }

        private static decimal ExtractHealth(string demonName)
        {
            int health = 0;
            string healthPattern = @"[^0-9+\-*/.]";
            MatchCollection healthMatches = Regex.Matches(demonName, healthPattern);
            foreach (Match healthMatch in healthMatches)
            {
                health += char.Parse(healthMatch.Value);
            }

            return health;
        }

        private static decimal ExtractDamage(string demonName)
        {
            decimal damage = 0;
            string damagePattern = @"[+-]?\d+(\.\d+)?";
            MatchCollection damageMatches = Regex.Matches(demonName, damagePattern);
            foreach (Match damageMatch in damageMatches)
            {
                damage += decimal.Parse(damageMatch.Value);
            }

            string operatorsPattern = @"[*/]";
            MatchCollection operatorsMatches = Regex.Matches(demonName, operatorsPattern);
            foreach (Match @operator in operatorsMatches)
            {
                if (@operator.Value == "*")
                {
                    damage *= 2;
                }
                else if (@operator.Value == "/")
                {
                    damage /= 2;
                }
            }

            return damage;
        }
    }
}