using System;

namespace _06BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            bool isBalanced = true;
            for (int i = 0; i < linesCount; i++)
            {                
                string line = Console.ReadLine();                
                if (line == "(")
                {
                    if (isBalanced == false)
                    {
                        break;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
                else if (line == ")")
                {
                    if (isBalanced == false)
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
