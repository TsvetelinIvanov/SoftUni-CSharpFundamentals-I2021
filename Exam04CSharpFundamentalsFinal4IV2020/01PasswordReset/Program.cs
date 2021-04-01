using System;

namespace _01PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string passwordOperationsString;
            while ((passwordOperationsString = Console.ReadLine()) != "Done")
            {
                string[] passwordOperations = passwordOperationsString.Split();
                string command = passwordOperations[0];
                switch (command)
                {
                    case "TakeOdd":
                        string newPassword = string.Empty;
                        for (int i = 1; i < password.Length; i += 2)
                        {
                            newPassword += password[i];
                        }

                        password = newPassword;
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(passwordOperations[1]);
                        int length = int.Parse(passwordOperations[2]);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string replaced = passwordOperations[1];
                        string replacement = passwordOperations[2];
                        if (password.Contains(replaced))
                        {
                            password = password.Replace(replaced, replacement);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                    default:
                        throw new AggregateException("Invalid command!");
                }
            }

            Console.WriteLine("Your password is: " + password);
        }
    }
}