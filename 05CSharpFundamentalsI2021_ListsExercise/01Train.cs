using System;
using System.Linq;
using System.Collections.Generic;

namespace _01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] passengersOrWagon = input.Split();
                if (passengersOrWagon[0] == "Add")
                {
                    int wagon = int.Parse(passengersOrWagon[1]);
                    wagons.Add(wagon);
                }
                else
                {
                    int passengersCount = int.Parse(passengersOrWagon[0]);
                    FitPassengers(wagons, wagonCapacity, passengersCount);
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void FitPassengers(List<int> wagons, int wagonCapacity, int passengersCount)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + passengersCount <= wagonCapacity)
                {
                    wagons[i] += passengersCount;
                    break;
                }
            }
        }
    }
}
