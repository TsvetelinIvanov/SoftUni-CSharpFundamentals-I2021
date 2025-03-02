using System;
using System.Collections.Generic;

namespace _03SpeedRacing
{
    class Car
    {
        public Car(string model, double fuelAmount, double consumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.ConsumtionPerKilometer = consumptionPerKilometer;
            this.TraveledDistance = 0;
        }

        public string Model { get; }

        public double FuelAmount { get; private set; }

        public double ConsumtionPerKilometer { get; }

        public int TraveledDistance { get; private set; }

        public void Drive(int distance)
        {
            if (this.ConsumtionPerKilometer * distance <= this.FuelAmount)
            {
                this.FuelAmount -= this.ConsumtionPerKilometer * distance;
                this.TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TraveledDistance}";
        }
    }
    
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
                double fuel = double.Parse(carData[1]);
                double consumptionPerKilometer = double.Parse(carData[2]);
                
                Car car = new Car(model, fuel, consumptionPerKilometer);
                cars.Add(car);
            }

            string drivingData;
            while ((drivingData = Console.ReadLine()) != "End")
            {
                string model = drivingData.Split()[1];
                int distance = int.Parse(drivingData.Split()[2]);
                
                Car car = cars.Find(c => c.Model == model);
                car.Drive(distance);
            }

            cars.ForEach(c => Console.WriteLine(c));
        }
    }
}
