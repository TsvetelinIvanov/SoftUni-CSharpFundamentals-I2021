using System;

namespace _04MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morseText = Console.ReadLine().Split('|');
            string text = string.Empty;
            foreach (string morseWord in morseText)
            {
                string word = TranslateFromMorseToEnglish(morseWord);
                text += word + " ";
            }

            Console.WriteLine(text.TrimEnd());
        }

        private static string TranslateFromMorseToEnglish(string morseWord)
        {
            string[] morseLetters = morseWord.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string word = string.Empty;            
            foreach (string morseLetter in morseLetters)
            {
                switch (morseLetter)
                {
                    case ".-":
                        word += "A";
                        break;
                    case "-...":
                        word += "B";
                        break;
                    case "-.-.":
                        word += "C";
                        break;
                    case "-..":
                        word += "D";
                        break;
                    case ".":
                        word += "E";
                        break;
                    case "..-.":
                        word += "F";
                        break;
                    case "--.":
                        word += "G";
                        break;
                    case "....":
                        word += "H";
                        break;
                    case "..":
                        word += "I";
                        break;
                    case ".---":
                        word += "J";
                        break;
                    case "-.-":
                        word += "K";
                        break;
                    case ".-..":
                        word += "L";
                        break;
                    case "--":
                        word += "M";
                        break;
                    case "-.":
                        word += "N";
                        break;
                    case "---":
                        word += "O";
                        break;
                    case ".--.":
                        word += "P";
                        break;
                    case "--.-":
                        word += "Q";
                        break;
                    case ".-.":
                        word += "R";
                        break;
                    case "...":
                        word += "S";
                        break;
                    case "-":
                        word += "T";
                        break;
                    case "..-":
                        word += "U";
                        break;
                    case "...-":
                        word += "V";
                        break;
                    case ".--":
                        word += "W";
                        break;
                    case "-..-":
                        word += "X";
                        break;
                    case "-.--":
                        word += "Y";
                        break;
                    case "--..":
                        word += "Z";
                        break;                    
                }
            }

            return word;
        }
    }
}