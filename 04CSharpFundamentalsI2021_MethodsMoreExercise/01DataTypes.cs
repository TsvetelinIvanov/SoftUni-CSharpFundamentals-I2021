using System;

namespace _01DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int integer = int.Parse(Console.ReadLine());
                    PrintResult(integer);
                    break;
                case "real":
                    double number = double.Parse(Console.ReadLine());
                    PrintResult(number);
                    break;
                case "string":
                    string word = Console.ReadLine();
                    PrintResult(word);
                    break;
            }
        }

        private static void PrintResult(int number)
        {
            int result = number * 2;
            Console.WriteLine(result);
        }

        private static void PrintResult(double number)
        {
            double result = number * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        private static void PrintResult(string word)
        {
            string result = "$" + word + "$";
            Console.WriteLine(result);
        }
    }
}
