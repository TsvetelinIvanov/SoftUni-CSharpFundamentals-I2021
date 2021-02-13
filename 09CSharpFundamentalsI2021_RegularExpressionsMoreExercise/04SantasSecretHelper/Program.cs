using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> childrenNames = new List<string>();
            int key = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"(@[A-Za-z]+)[^@!:>-]*(![GN]!)");
            string encryptedMessage;
            while ((encryptedMessage = Console.ReadLine()) != "end")
            {
                string decryptedMessage = DecryptMessage(encryptedMessage, key);
                //Console.WriteLine(decryptedMessage);
                Match match = regex.Match(decryptedMessage);
                if (match.Success)
                {
                    string behaviour = match.Groups[2].Value.Trim('!');
                    if (behaviour == "G")
                    {
                        string childName = match.Groups[1].Value.TrimStart('@');
                        childrenNames.Add(childName);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, childrenNames));
        }

        private static string DecryptMessage(string encryptedMessage, int key)
        {
            string decryptedMessage = string.Empty;
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                decryptedMessage += (char)(encryptedMessage[i] - key);
            }

            return decryptedMessage;
        }
    }
}