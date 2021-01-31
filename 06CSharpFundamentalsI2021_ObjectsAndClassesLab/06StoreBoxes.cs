using System;
using System.Linq;
using System.Collections.Generic;

namespace _06StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string boxDataString;
            while ((boxDataString = Console.ReadLine()) != "end")
            {
                string[] boxData = boxDataString.Split();
                int serialNumber = int.Parse(boxData[0]);
                string itemName = boxData[1];
                int itemQuantity = int.Parse(boxData[2]);
                decimal itemPrice = decimal.Parse(boxData[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity
                };

                boxes.Add(box);
            }

            boxes.OrderByDescending(b => b.BoxPrice).ToList().ForEach(b => Console.Write($"{b.SerialNumber}{Environment.NewLine}-- {b.Item.Name} - ${b.Item.Price:f2}: {b.ItemQuantity}{Environment.NewLine}-- ${b.BoxPrice:f2}{Environment.NewLine}"));
        }
    }

    class Box
    {
        public int SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal BoxPrice => this.ItemQuantity * this.Item.Price;
    }

    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
