using System;
using System.Text.RegularExpressions;

namespace _02Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex messageRegex = new Regex(@"(@|\*)([A-Z][a-z]{2,})\1: \[([A-Za-z])\]\|\[([A-Za-z])\]\|\[([A-Za-z])\]\|$");
            int messagesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messagesCount; i++)
            {
                string rawMessage = Console.ReadLine();
                Match messageMatch = messageRegex.Match(rawMessage);
                if (messageMatch.Success)
                {
                    Console.WriteLine($"{messageMatch.Groups[2].Value}: {(int)messageMatch.Groups[3].Value[0]} {(int)messageMatch.Groups[4].Value[0]} {(int)messageMatch.Groups[5].Value[0]}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}