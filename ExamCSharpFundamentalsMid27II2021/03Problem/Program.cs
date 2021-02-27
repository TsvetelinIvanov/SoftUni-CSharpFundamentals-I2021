using System;
using System.Linq;
using System.Collections.Generic;

namespace _03Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] chatCommandLine = input.Split();
                string chatCommand = chatCommandLine[0];
                switch (chatCommand)
                {
                    case "Chat":
                        string messageToAdd = chatCommandLine[1];
                        messages.Add(messageToAdd);
                        break;
                    case "Delete":
                        string messageToDelete = chatCommandLine[1];
                        messages.Remove(messageToDelete);
                        break;
                    case "Edit":
                        string messageToEdit = chatCommandLine[1];
                        string editedMessage = chatCommandLine[2];
                        for (int i = 0; i < messages.Count; i++)
                        {
                            if (messages[i] == messageToEdit)
                            {
                                messages[i] = editedMessage;
                                break;
                            }
                        }

                        break;
                    case "Pin":
                        string messageToPin = chatCommandLine[1];
                        messages.Remove(messageToPin);
                        messages.Add(messageToPin);
                        break;
                    case "Spam":
                        IEnumerable<string> messagesToAdd = chatCommandLine.Skip(1);
                        messages.AddRange(messagesToAdd);
                        break;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, messages));
        }        
    }
}