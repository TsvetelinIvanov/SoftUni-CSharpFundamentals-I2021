using System;
using System.Collections.Generic;

namespace _04Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<decimal, int>> products = new Dictionary<string, KeyValuePair<decimal, int>>();
            
            string productDataString;
            while ((productDataString = Console.ReadLine()) != "buy")
            {
                string[] productData = productDataString.Split();
                string name = productData[0];
                decimal price = decimal.Parse(productData[1]);
                int quantity = int.Parse(productData[2]);
                if (products.ContainsKey(name))
                {
                    int newQuantity = products[name].Value + quantity;
                    products[name] = new KeyValuePair<decimal, int>(price, newQuantity);
                }
                else
                {
                    products.Add(name, new KeyValuePair<decimal, int>(price, quantity));
                }
            }

            foreach (KeyValuePair<string, KeyValuePair<decimal, int>> product in products)
            {
                decimal totalPrice = product.Value.Key * product.Value.Value;
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}
