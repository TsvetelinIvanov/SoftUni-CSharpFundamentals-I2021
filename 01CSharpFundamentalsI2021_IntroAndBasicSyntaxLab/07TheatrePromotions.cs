using System;

namespace _07TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            string price = "Error!";

            bool isChild = age >= 0 && age <= 18;
            bool isAdult = age >= 19 && age <= 64;
            bool isPensioner = age >= 65 && age <= 122;
            if (dayType == "weekday")
            {
                if (isChild || isPensioner)
                {
                    price = "12$";
                }
                else if (isAdult)
                {
                    price = "18$";
                }
            }
            else if (dayType == "weekend")
            {
                if (isChild || isPensioner)
                {
                    price = "15$";
                }
                else if (isAdult)
                {
                    price = "20$";
                }
            }
            else if (dayType == "holiday")
            {
                if (isChild)
                {
                    price = "5$";
                }
                else if (isAdult)
                {
                    price = "12$";
                }
                else if (isPensioner)
                {
                    price = "10$";
                }
            }

            Console.WriteLine(price);
        }
    }
}
