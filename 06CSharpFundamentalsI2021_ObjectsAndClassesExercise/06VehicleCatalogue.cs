using System;
using System.Linq;
using System.Collections.Generic;

namespace _06VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.Type = type[0].ToString().ToUpper() + type.Substring(1);
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Type { get; }

        public string Model { get; }

        public string Color { get; }

        public int Horsepower { get; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleData = input.Split();
                string type = vehicleData[0];
                string model = vehicleData[1];
                string color = vehicleData[2];
                int horsepower = int.Parse(vehicleData[3]);
                Vehicle vehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = input;
                Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == model);
                
                Console.WriteLine("Type: " + vehicle.Type);
                Console.WriteLine("Model: " + vehicle.Model);
                Console.WriteLine("Color: " + vehicle.Color);
                Console.WriteLine("Horsepower: " + vehicle.Horsepower);
            }

            double carsHorsepower = vehicles.Count(v => v.Type == "Car") > 0 ? vehicles.Where(v => v.Type == "Car").Average(v => v.Horsepower) : 0;
            double trucksHorsepower = vehicles.Count(v => v.Type == "Truck") > 0 ? vehicles.Where(v => v.Type == "Truck").Average(v => v.Horsepower) : 0;
            
            Console.WriteLine($"Cars have average horsepower of: {carsHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksHorsepower:f2}.");
        }
    }
}
