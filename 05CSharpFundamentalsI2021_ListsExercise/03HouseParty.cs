using System;
using System.Collections.Generic;

namespace _03HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestNames = new List<string>();
            int messagesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messagesCount; i++)
            {
                string[] messageParts = Console.ReadLine().Split();
                string guestName = messageParts[0];
                if (messageParts.Length == 3)
                {
                    if (guestNames.Contains(guestName))
                    {
                        Console.WriteLine(guestName + " is already in the list!");
                    }
                    else
                    {
                        guestNames.Add(guestName);
                    }
                }
                else if (messageParts.Length == 4)
                {
                    if (guestNames.Contains(guestName))
                    {
                        guestNames.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine(guestName + " is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guestNames));
        }
    }
}
