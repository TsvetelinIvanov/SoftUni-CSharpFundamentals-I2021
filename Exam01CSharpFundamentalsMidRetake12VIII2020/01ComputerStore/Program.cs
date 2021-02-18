using System;

namespace _01ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalPriceWithoutTax = 0;
            string input = Console.ReadLine();
            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);
                if (price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();

                    continue;
                }

                totalPriceWithoutTax += price;

                input = Console.ReadLine();
            }

            string output = "Invalid order!";
            if (totalPriceWithoutTax > 0)
            {                
                decimal tax = totalPriceWithoutTax * 0.2m;                
                decimal totalPrice = totalPriceWithoutTax + tax;
                if (input == "special")
                {
                    totalPrice *= 0.9m;
                }

                output = $"Congratulations you've just bought a new computer!{Environment.NewLine}Price without taxes: {totalPriceWithoutTax:f2}${Environment.NewLine}Taxes: {tax:f2}${Environment.NewLine}{new string('-', 11)}{Environment.NewLine}Total price: {totalPrice:f2}$";
            }

            Console.WriteLine(output);
        }
    }
}