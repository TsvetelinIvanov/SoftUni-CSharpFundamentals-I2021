using System;
using System.Collections.Generic;
using System.Linq;

namespace _03NeedForSpeedIII
{
    class Program
    {
        private const int MaxMileage = 100000;
        private const int MinMileage = 10000;
        private const int TankCapacity = 75;

        static void Main(string[] args)
        {
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();
            int carsCountN = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCountN; i++)
            {
                string[] carData = Console.ReadLine().Split('|');
                string model = carData[0];
                int mileage = int.Parse(carData[1]);
                int fuel = int.Parse(carData[2]);
                cars.Add(model, new int[] { mileage, fuel });
            }

            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "Stop")
            {
                string[] commandLine = commandLineString.Split(" : ");
                string command = commandLine[0];
                switch (command)
                {
                    case "Drive":
                        DriveCar(cars, commandLine);
                        break;
                    case "Refuel":
                        RefuelCar(cars, commandLine);
                        break;
                    case "Revert":
                        RevertCar(cars, commandLine);
                        break;
                    default:
                        throw new ArgumentException("Invalid command!");
                }
            }

            foreach (KeyValuePair<string, int[]> car in cars.OrderByDescending(c => c.Value[0]).ThenBy(c => c.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }

        private static void DriveCar(Dictionary<string, int[]> cars, string[] commandLine)
        {
            string model = commandLine[1];
            int distance = int.Parse(commandLine[2]);
            int consumedFuel = int.Parse(commandLine[3]);
            if (cars[model][1] >= consumedFuel)
            {
                cars[model][1] -= consumedFuel;
                cars[model][0] += distance;
                Console.WriteLine($"{model} driven for {distance} kilometers. {consumedFuel} liters of fuel consumed.");
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }

            if (cars[model][0] >= MaxMileage)
            {
                cars.Remove(model);
                Console.WriteLine($"Time to sell the {model}!");
            }
        }

        private static void RefuelCar(Dictionary<string, int[]> cars, string[] commandLine)
        {
            string model = commandLine[1];
            int fuel = int.Parse(commandLine[2]);
            if (cars[model][1] + fuel > TankCapacity)
            {
                Console.WriteLine($"{model} refueled with {TankCapacity - cars[model][1]} liters");
                cars[model][1] = TankCapacity;                
            }
            else
            {
                Console.WriteLine($"{model} refueled with {fuel} liters");
                cars[model][1] += fuel;
            }
        }

        private static void RevertCar(Dictionary<string, int[]> cars, string[] commandLine)
        {
            string model = commandLine[1];
            int decreasingDistance = int.Parse(commandLine[2]);
            if (cars[model][0] - decreasingDistance < MinMileage)
            {
                cars[model][0] = MinMileage;
            }
            else
            {
                cars[model][0] -= decreasingDistance;
                Console.WriteLine($"{model} mileage decreased by {decreasingDistance} kilometers");
            }
        }
    }
}