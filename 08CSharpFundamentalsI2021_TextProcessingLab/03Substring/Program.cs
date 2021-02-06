using System;

namespace _03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeString = Console.ReadLine().ToLower();
            string text = Console.ReadLine();
            int removeIndex = text.IndexOf(removeString);
            while (removeIndex != -1)
            {
                text = text.Remove(removeIndex, removeString.Length);
                removeIndex = text.IndexOf(removeString);
            }

            Console.WriteLine(text);
        }
    }
}