using System;
using System.Linq;

namespace _03TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keyNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char treasureTypeCharacter = '&';
            char treasureCoordinatesStartCharacter = '<';
            char treasureCoordinatesEndCharacter = '>';
            
            string encryptedMessage;
            while ((encryptedMessage = Console.ReadLine()) != "find")
            {
                string decryptedMessage = DecryptMessage(keyNumbers, encryptedMessage);
                int treasureTypeStartIndex = decryptedMessage.IndexOf(treasureTypeCharacter) + 1;
                int treasureTypeEndIndex = decryptedMessage.LastIndexOf(treasureTypeCharacter);
                int treasureCoordinatesStartIndex = decryptedMessage.IndexOf(treasureCoordinatesStartCharacter) + 1;
                int treasureCoordinatesEndIndex = decryptedMessage.IndexOf(treasureCoordinatesEndCharacter);

                string treasureType = decryptedMessage.Substring(treasureTypeStartIndex, treasureTypeEndIndex - treasureTypeStartIndex);
                string treasureCoordinates = decryptedMessage.Substring(treasureCoordinatesStartIndex, treasureCoordinatesEndIndex - treasureCoordinatesStartIndex);
                Console.WriteLine($"Found {treasureType} at {treasureCoordinates}");
            }
        }

        private static string DecryptMessage(int[] keyNumbers, string encryptedMessage)
        {
            string decryptedMessage = string.Empty;
            int keyIndex = 0;
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char decryptedCharacter = (char)(encryptedMessage[i] - keyNumbers[keyIndex]);
                decryptedMessage += decryptedCharacter;
                keyIndex++;
                if (keyIndex == keyNumbers.Length)
                {
                    keyIndex = 0;
                }
            }

            //Console.WriteLine(decryptedMessage);
            return decryptedMessage;            
        }
    }
}
