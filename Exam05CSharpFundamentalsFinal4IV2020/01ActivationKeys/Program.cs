using System;

namespace _01ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "Generate")
            {
                string[] commandLine = commandLineString.Split(">>>");
                string command = commandLine[0];
                switch (command)
                {
                    case "Contains":
                        string substring = commandLine[1];
                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine(activationKey + " contains " + substring);
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }

                        break;
                    case "Flip":
                        string subCommand = commandLine[1];
                        if (subCommand == "Upper")
                        {
                            activationKey = DoUpperInRange(activationKey, int.Parse(commandLine[2]), int.Parse(commandLine[3]));
                        }
                        else if (subCommand == "Lower")
                        {
                            activationKey = DoLowerInRange(activationKey, int.Parse(commandLine[2]), int.Parse(commandLine[3]));
                        }

                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        int startIndex = int.Parse(commandLine[1]);
                        int endIndex = int.Parse(commandLine[2]);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                    default:
                        throw new ArgumentException("Invalid command!");
                }
            }

            Console.WriteLine("Your activation key is: " + activationKey);
        }

        private static string DoUpperInRange(string activationKey, int startIndex, int endIndex)
        {
            string substring = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
            activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
            activationKey = activationKey.Substring(0, startIndex) + substring + activationKey[startIndex..];

            return activationKey;
        }

        private static string DoLowerInRange(string activationKey, int startIndex, int endIndex)
        {
            string substring = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
            activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
            activationKey = activationKey.Substring(0, startIndex) + substring + activationKey[startIndex..];

            return activationKey;
        }
    }
}