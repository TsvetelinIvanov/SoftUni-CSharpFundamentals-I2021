using System;

namespace _01TheLimitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "Decode")
            {
                string[] commandLine = commandLineString.Split('|');
                string command = commandLine[0];
                switch (command)
                {
                    case "Move":
                        int lettersCount = int.Parse(commandLine[1]);
                        message = message[lettersCount..] + message.Substring(0, lettersCount);
                        break;
                    case "Insert":
                        int index = int.Parse(commandLine[1]);
                        string value = commandLine[2];
                        message = message.Substring(0, index) + value + message[index..];
                        break;
                    case "ChangeAll":
                        string replaced = commandLine[1];
                        string replacement = commandLine[2];
                        message = message.Replace(replaced, replacement);
                        break;
                }
            }

            Console.WriteLine("The decrypted message is: " + message);
        }
    }
}