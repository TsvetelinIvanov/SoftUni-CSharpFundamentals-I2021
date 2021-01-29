using System;
using System.Collections.Generic;
using System.Linq;

namespace _03TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> encryptedCharacters = new List<char>();
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if (char.IsDigit(encryptedMessage[i]))
                {
                    numbers.Add(int.Parse(encryptedMessage[i].ToString()));
                }
                else
                {
                    encryptedCharacters.Add(encryptedMessage[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            List<char> decryptedCharacters = new List<char>();            
            for (int i = 0; i < takeList.Count; i++)
            {
                char[] tackenCharacters = encryptedCharacters.Take(takeList[i]).ToArray();
                decryptedCharacters.AddRange(tackenCharacters);
                encryptedCharacters = encryptedCharacters.Skip(takeList[i]).ToList();
                encryptedCharacters = encryptedCharacters.Skip(skipList[i]).ToList();
            }

            Console.WriteLine(string.Join("", decryptedCharacters));
        }
    }
}
