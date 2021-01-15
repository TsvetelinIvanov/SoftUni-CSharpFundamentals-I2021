using System;

namespace _07VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            string input;
            while ((input = Console.ReadLine()) != "Start")
            {
                double inputCoin = double.Parse(input);
                if (inputCoin == 0.1 || inputCoin == 0.2 || inputCoin == 0.5 || inputCoin == 1 || inputCoin == 2)
                {
                    money += inputCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputCoin}");
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                switch (input.ToLower())
                {
                    case "nuts":
                        if (money >= 2)
                        {
                            money -= 2;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "water":
                        if (money >= 0.7)
                        {
                            money -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "crisps":
                        if (money >= 1.5)
                        {
                            money -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "soda":
                        if (money >= 0.8)
                        {
                            money -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "coke":
                        if (money >= 1)
                        {
                            money -= 1;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }

            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
