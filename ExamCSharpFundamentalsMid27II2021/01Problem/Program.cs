using System;

namespace _01Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int month = 30;
            int workerBiscuitsPerDay = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int competingFactoryBiscuitsCount = int.Parse(Console.ReadLine());
            int factoryBiscuitsCount = 0;
            for (int i = 1; i <= month; i++)
            {
                if (i % 3 == 0)
                {
                    factoryBiscuitsCount += (int)(workerBiscuitsPerDay * workersCount * 0.75);
                }
                else
                {
                    factoryBiscuitsCount += workerBiscuitsPerDay * workersCount;
                }
            }

            int difference = Math.Abs(factoryBiscuitsCount - competingFactoryBiscuitsCount);
            double percentageDifference = (double)difference / competingFactoryBiscuitsCount * 100;

            Console.WriteLine($"You have produced {factoryBiscuitsCount} biscuits for the past month.");
            if (factoryBiscuitsCount > competingFactoryBiscuitsCount)
            {
                Console.WriteLine($"You produce {percentageDifference:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentageDifference:f2} percent less biscuits.");
            }
        }
    }
}