using System;
using System.Collections.Generic;

namespace _05SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            
            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandLine = Console.ReadLine().Split();
                string command = commandLine[0];
                string username = commandLine[1];
                switch (command)
                {
                    case "register":
                        string plateNumber = commandLine[2];
                        Register(parking, username, plateNumber);
                        break;
                    case "unregister":
                        Unregister(parking, username);
                        break;
                }
            }

            foreach (KeyValuePair<string, string> car in parking)
            {
                Console.WriteLine(car.Key + " => " + car.Value);
            }
        }

        private static void Register(Dictionary<string, string> parking, string username, string plateNumber)
        {
            if (parking.ContainsKey(username))
            {
                Console.WriteLine("ERROR: already registered with plate number " + parking[username]);
            }
            else
            {
                parking.Add(username, plateNumber);
                Console.WriteLine($"{username} registered {plateNumber} successfully");
            }
        }

        private static void Unregister(Dictionary<string, string> parking, string username)
        {
            if (parking.ContainsKey(username))
            {
                parking.Remove(username);
                Console.WriteLine(username + " unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
        }
    }
}
