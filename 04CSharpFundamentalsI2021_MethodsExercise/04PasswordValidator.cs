using System;
using System.Text;

namespace _04PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string message = CheckPassword(password);
            Console.Write(message);
        }

        private static string CheckPassword(string password)
        {
            StringBuilder messageBuilder = new StringBuilder();
            bool isInLength = CheckLength(password);
            bool isOnlyByLettersAndDigits = CheckForOnlyLettersAndDigits(password);
            bool containsEnoughDigits = CheckIfContainsEnoughDigits(password);            

            if (isInLength && isOnlyByLettersAndDigits && containsEnoughDigits)
            {
                messageBuilder.AppendLine("Password is valid");
            }
            else
            {
                if (!isInLength)
                {
                    messageBuilder.AppendLine("Password must be between 6 and 10 characters");
                }

                if (!isOnlyByLettersAndDigits)
                {
                    messageBuilder.AppendLine("Password must consist only of letters and digits");
                }

                if (!containsEnoughDigits)
                {
                    messageBuilder.AppendLine("Password must have at least 2 digits");
                }
            }

            return messageBuilder.ToString();
        }

        private static bool CheckLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        private static bool CheckForOnlyLettersAndDigits(string password)
        {            
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsDigit(password[i]) && !char.IsLetter(password[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckIfContainsEnoughDigits(string password)
        {
            int digitsCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digitsCount++;
                }
            }

            return digitsCount >= 2;
        }
    }
}
