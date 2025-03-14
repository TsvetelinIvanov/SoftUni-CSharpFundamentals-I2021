using System;
using System.Linq;

namespace _01SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "Reveal")
            {
                string[] commandline = commandLineString.Split(":|:");
                string command = commandline[0];
                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(commandline[1]);
                        message = message.Substring(0, index) + " " + message[index..];
                        Console.WriteLine(message);
                        break;
                    case "Reverse":
                        string substring = commandline[1];
                        int substringIndex = message.IndexOf(substring);
                        if (substringIndex < 0)
                        {
                            Console.WriteLine("error");
                            break; ;
                        }

                        message = message.Remove(substringIndex, substring.Length);
                        substring = string.Join("", substring.Reverse());
                        message += substring;
                        Console.WriteLine(message);
                        break;
                    case "ChangeAll":
                        string replaced = commandline[1];
                        string replacement = commandline[2];
                        message = message.Replace(replaced, replacement);
                        Console.WriteLine(message);
                        break;
                }                
            }

            Console.WriteLine("You have a new text message: " + message);
        }
    }
}
