using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string messagePattern = @"(@[A-Za-z]+)[^@!:>-]*(:\d+)[^@!:>-]*(\![AD]\!)[^@!:>-]*(->\d+)";
            Regex messageRegex = new Regex(messagePattern);
            
            int messagesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messagesCount; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);
                Match messageMatch = messageRegex.Match(decryptedMessage);
                if (messageMatch.Success)
                {
                    string planetName = messageMatch.Groups[1].Value.TrimStart('@');
                    //int population = int.Parse(messageMatch.Groups[2].Value.TrimStart(':'));
                    string attackType = messageMatch.Groups[3].Value.Trim('!');
                    //int soldiersCount = int.Parse(messageMatch.Groups[4].Value.TrimStart('-', '>'));
                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            attackedPlanets.Sort();
            Console.WriteLine("Attacked planets: " + attackedPlanets.Count);
            if (attackedPlanets.Count > 0)
            {
                Console.WriteLine("-> " + string.Join(Environment.NewLine + "-> ", attackedPlanets));
            }

            destroyedPlanets.Sort();
            Console.WriteLine("Destroyed planets: " + destroyedPlanets.Count);
            if (destroyedPlanets.Count > 0)
            {
                Console.WriteLine("-> " + string.Join(Environment.NewLine + "-> ", destroyedPlanets));
            }
        }

        private static string DecryptMessage(string encryptedMessage)
        {
            string keyPattern = @"[STARstar]";
            Regex keyRegex = new Regex(keyPattern);
            MatchCollection keyCollection = keyRegex.Matches(encryptedMessage);
            int key = keyCollection.Count;
            
            string decryptedMessage = string.Empty;
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                decryptedMessage += (char)(encryptedMessage[i] - key);
            }

            return decryptedMessage;
        }
    }
}
