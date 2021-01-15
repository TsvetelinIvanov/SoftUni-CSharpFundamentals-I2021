using System;

namespace _05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = 0; i < username.Length; i++)
            {
                password += username[username.Length - 1 - i];
            }

            bool isLoggedIn = false;
            for (int i = 0; i < 3; i++)
            {
                string inputPassword = Console.ReadLine();
                if (inputPassword == password)
                {
                    isLoggedIn = true;
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }

            if (!isLoggedIn)
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
