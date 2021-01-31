using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogVehicle catalogVehicle = new CatalogVehicle();
            string vehicleDataString;
            while ((vehicleDataString = Console.ReadLine()) != "end")
            {
                string[] vehicleData = vehicleDataString.Split('/');
                string vehicleType = vehicleData[0];
                string vehicleBrand = vehicleData[1];
                string vehicleModel = vehicleData[2];
                if (vehicleType == "Car")
                {
                    int horsePower = int.Parse(vehicleData[3]);
                    Car car = new Car(vehicleBrand, vehicleModel, horsePower);
                    catalogVehicle.Cars.Add(car);
                }
                else if (vehicleType == "Truck")
                {
                    int weight = int.Parse(vehicleData[3]);
                    Truck truck = new Truck(vehicleBrand, vehicleModel, weight);
                    catalogVehicle.Trucks.Add(truck);
                }
            }

            Console.WriteLine(catalogVehicle);
        }

        class CatalogVehicle
        {
            public CatalogVehicle()
            {
                this.Cars = new List<Car>();
                this.Trucks = new List<Truck>();
            }

            public List<Car> Cars { get; }

            public List<Truck> Trucks { get; }

            public override string ToString()
            {
                StringBuilder catalogBuilder = new StringBuilder();
                if (this.Cars.Count > 0)
                {
                    catalogBuilder.AppendLine("Cars:");
                    foreach (Car car in this.Cars.OrderBy(c => c.Brand))
                    {
                        catalogBuilder.AppendLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                    }                    
                }

                if (this.Trucks.Count > 0)
                {
                    catalogBuilder.AppendLine("Trucks:");
                    foreach (Truck truck in this.Trucks.OrderBy(t => t.Brand))
                    {
                        catalogBuilder.AppendLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                    }
                }

                return catalogBuilder.ToString().TrimEnd();
            }
        }

        class Car
        {
            public Car(string brand, string model, int horsePower)
            {
                this.Brand = brand;
                this.Model = model;
                this.HorsePower = horsePower;
            }

            public string Brand { get; }

            public string Model { get; }

            public int HorsePower { get; }
        }

        class Truck
        {
            public Truck(string brand, string model, int weight)
            {
                this.Brand = brand;
                this.Model = model;
                this.Weight = weight;
            }

            public string Brand { get; }

            public string Model { get; }

            public int Weight { get; }
        }        
    }
}
