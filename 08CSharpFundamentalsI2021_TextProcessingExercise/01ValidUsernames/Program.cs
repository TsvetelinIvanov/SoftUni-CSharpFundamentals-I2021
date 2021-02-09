using System;

namespace _01ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (string username in usernames)
            {
                bool isUsenameValid = CheckUsername(username);
                if (isUsenameValid)
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool CheckUsername(string username)
        {            
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            foreach (char character in username)
            {
                if (!char.IsLetterOrDigit(character) && character != '_' && character != '-')
                {
                    return false;
                }
            }

            return true;
        }
    }
}