using System;

namespace _03GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal disposableMoney = decimal.Parse(Console.ReadLine());
            decimal balance = disposableMoney;            
            string gameName;
            while ((gameName = Console.ReadLine()) != "Game Time")
            {
                switch (gameName)
                {
                    case "OutFall 4":
                        if (balance >= 39.99m)
                        {
                            balance -= 39.99m;                            
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "CS: OG":
                        if (balance >= 15.99m)
                        {
                            balance -= 15.99m;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99m)
                        {
                            balance -= 19.99m;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "Honored 2":
                        if (balance >= 59.99m)
                        {
                            balance -= 59.99m;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "RoverWatch":
                        if (balance >= 29.99m)
                        {
                            balance -= 29.99m;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99m)
                        {
                            balance -= 39.99m;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;                    
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${Math.Abs(balance - disposableMoney)}. Remaining: ${balance}");
        }
    }
}
