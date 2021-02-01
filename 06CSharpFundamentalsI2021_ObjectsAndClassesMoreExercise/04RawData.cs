using System;
using System.Linq;
using System.Collections.Generic;

namespace _04RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split();
                string model = carData[0];
                int speed = int.Parse(carData[1]);
                int power = int.Parse(carData[2]);
                int weight = int.Parse(carData[3]);
                string type = carData[4];
                Car car = new Car(model, speed, power, weight, type);
                cars.Add(car);
            }

            string cargoType = Console.ReadLine();
            if (cargoType == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile" && c.Cargo.Weight < 1000).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
            else if (cargoType == "flamable")
            {
                cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            this.Model = model;
            this.Engine = new Engine(speed, power);
            this.Cargo = new Cargo(weight, type);
        }

        public string Model { get; }

        public Engine Engine { get; }

        public Cargo Cargo { get; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight { get; }

        public string Type { get; }
    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed { get; }

        public int Power { get; }
    }
}
