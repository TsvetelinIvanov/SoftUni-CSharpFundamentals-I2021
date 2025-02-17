using System;

namespace _04CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuriesCount = int.Parse(Console.ReadLine());
            
            int yearsCount = centuriesCount * 100;
            int daysCount = (int)(yearsCount * 365.2422);
            int hoursCount = daysCount * 24;
            int minutesCount = hoursCount * 60;

            Console.WriteLine($"{centuriesCount} centuries = {yearsCount} years = {daysCount} days = {hoursCount} hours = {minutesCount} minutes");
        }
    }
}
