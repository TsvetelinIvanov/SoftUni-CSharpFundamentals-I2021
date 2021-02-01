using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries)
                .Select(personData => new Person(personData.Split('=').First(), int.Parse(personData.Split('=').Last())))
                .ToArray();
            Product[] products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries)
                .Select(productData => new Product(productData.Split('=').First(), int.Parse(productData.Split('=').Last())))
                .ToArray();

            string buying;
            while ((buying = Console.ReadLine()) != "END")
            {
                string personName = buying.Split().First();
                string productName = buying.Split().Last();

                Person person = people.First(p => p.Name == personName);
                Product product = products.First(p => p.Name == productName);

                person.BuyProduct(product);
            }

            Console.WriteLine(string.Join(Environment.NewLine, people.Select(p => p)));
        }
    }

    class Person
    {
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }

        public string Name { get; }

        public int Money { get; private set; }

        public List<Product> Bag { get; }

        public void BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.Bag.Add(product);
                Console.WriteLine(this.Name + " bought " + product.Name);
            }
            else
            {
                Console.WriteLine(this.Name + " can't afford " + product.Name);
            }
        }

        public override string ToString()
        {
            string boughtProductsString = this.Bag.Count == 0 ? "Nothing bought" : string.Join(", ", this.Bag.Select(p => p.Name));

            return this.Name + " - " + boughtProductsString;
        }
    }

    class Product
    {
        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name { get; }

        public int Cost { get; }        
    }
}
