using System;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double price = 0;
            switch (peopleType)
            {
                case "Students":
                    switch (weekDay)
                    {
                        case "Friday":
                            price = peopleCount * 8.45;
                            break;
                        case "Saturday":
                            price = peopleCount * 9.8;
                            break;
                        case "Sunday":
                            price = peopleCount * 10.46;
                            break;
                    }

                    if (peopleCount >= 30)
                    {
                        price *= 0.85;
                    }
                
                    break;
                case "Business":
                    switch (weekDay)
                    {
                        case "Friday":
                            price = peopleCount * 10.9;
                            if (peopleCount >= 100)
                            {
                                price -= 10 * 10.9;
                            }

                            break;
                        case "Saturday":
                            price = peopleCount * 15.6;
                            if (peopleCount >= 100)
                            {
                                price -= 10 * 15.6;
                            }

                            break;
                        case "Sunday":
                            price = peopleCount * 16;

                            if (peopleCount >= 100)
                            {
                                price -= 10 * 16;
                            }

                            break;
                    }                    

                    break;
                case "Regular":
                    switch (weekDay)
                    {
                        case "Friday":
                            price = peopleCount * 15;
                            break;
                        case "Saturday":
                            price = peopleCount * 20;
                            break;
                        case "Sunday":
                            price = peopleCount * 22.5;
                            break;
                    }

                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        price *= 0.95;
                    }

                    break;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
