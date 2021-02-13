using System;
using System.Text.RegularExpressions;

namespace _03SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerPattern = @"%[A-Z][a-z]+%";
            string productPattern = @"<\w+>";
            string countPattern = @"\|\d+\|";
            string pricePattern = @"\d+(\.\d+)?\$";

            Regex customerRegex = new Regex(customerPattern);
            Regex productRegex = new Regex(productPattern);
            Regex countRegex = new Regex(countPattern);
            Regex priceRegex = new Regex(pricePattern);

            decimal totalMoney = 0;
            string purchaseData;
            while ((purchaseData = Console.ReadLine()) != "end of shift")
            {
                Match customerMatch = customerRegex.Match(purchaseData);
                Match productMatch = productRegex.Match(purchaseData);
                Match countMatch = countRegex.Match(purchaseData);
                Match priceMatch = priceRegex.Match(purchaseData);
                //Console.WriteLine(customerMatch.Value.Trim('%') + " " + productMatch.Value.Trim('<', '>') + " " + countMatch.Value.Trim('|') + " " + priceMatch.Value.TrimEnd('$'));
                if (customerMatch.Success && productMatch.Success && countMatch.Success && priceMatch.Success)
                {                    
                    string customer = customerMatch.Value.Trim('%');
                    string product = productMatch.Value.Trim('<', '>');
                    int count = int.Parse(countMatch.Value.Trim('|'));
                    decimal price = decimal.Parse(priceMatch.Value.TrimEnd('$'));
                    decimal money = count * price;
                    totalMoney += money;

                    Console.WriteLine($"{customer}: {product} - {money:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalMoney:f2}");
        }
    }
}