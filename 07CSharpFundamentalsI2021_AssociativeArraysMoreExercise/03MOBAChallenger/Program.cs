using System;
using System.Linq;
using System.Collections.Generic;

namespace _03MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> tier = new Dictionary<string, Dictionary<string, int>>();
            MakeTier(tier);
            PrintTier(tier);
        }

        private static void MakeTier(Dictionary<string, Dictionary<string, int>> tier)
        {
            string playerDataString;
            while ((playerDataString = Console.ReadLine()) != "Season end")
            {
                if (playerDataString.Contains(" -> "))
                {
                    string[] playerData = playerDataString.Split(" -> ");
                    string player = playerData[0];
                    string position = playerData[1];
                    int skill = int.Parse(playerData[2]);
                    if (!tier.ContainsKey(player))
                    {
                        tier.Add(player, new Dictionary<string, int>());
                    }

                    if (!tier[player].ContainsKey(position) || tier[player][position] < skill)
                    {
                        tier[player][position] = skill;
                    }
                }
                else if (playerDataString.Contains(" vs "))
                {                    
                    string firstPlayer = playerDataString.Split(" vs ").First();
                    string secondPlayer = playerDataString.Split(" vs ").Last();

                    if (!tier.ContainsKey(firstPlayer) || !tier.ContainsKey(secondPlayer))
                    {
                        continue;
                    }

                    bool haveCommonPosition = CheckForCommonPosition(tier, firstPlayer, secondPlayer);
                    if (haveCommonPosition)
                    {
                        Duel(tier, firstPlayer, secondPlayer);
                    }
                }
            }
        }

        private static bool CheckForCommonPosition(Dictionary<string, Dictionary<string, int>> tier, string firstPlayer, string secondPlayer)
        {
            foreach (string position in tier[firstPlayer].Keys)
            {
                if (tier[secondPlayer].ContainsKey(position))
                {
                    return true;
                }
            }

            return false;
        }

        private static void Duel(Dictionary<string, Dictionary<string, int>> tier, string firstPlayer, string secondPlayer)
        {
            if (tier[firstPlayer].Values.Sum() > tier[secondPlayer].Values.Sum())
            {
                tier.Remove(secondPlayer);
            }
            else if (tier[secondPlayer].Values.Sum() > tier[firstPlayer].Values.Sum())
            {
                tier.Remove(firstPlayer);
            }
        }

        private static void PrintTier(Dictionary<string, Dictionary<string, int>> tier)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> player in tier.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (KeyValuePair<string, int> position in player.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}