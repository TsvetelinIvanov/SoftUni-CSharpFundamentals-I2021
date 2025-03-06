using System;

namespace _03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringForRemoving = Console.ReadLine().ToLower();
            string text = Console.ReadLine();
            int removeIndex = text.IndexOf(stringForRemoving);
            while (removeIndex != -1)
            {
                text = text.Remove(removeIndex, stringForRemoving.Length);
                removeIndex = text.IndexOf(stringForRemoving);
            }

            Console.WriteLine(text);
        }
    }
}
