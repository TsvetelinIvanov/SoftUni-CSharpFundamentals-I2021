using System;

namespace _04BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursCount = int.Parse(Console.ReadLine());
            int minutesCount = int.Parse(Console.ReadLine()) + 30;

            if (minutesCount >= 60)
            {
                minutesCount -= 60;
                hoursCount++;
            }

            if (hoursCount > 23)
            {
                hoursCount -= 24;
            }

            Console.WriteLine($"{hoursCount}:{minutesCount:d2}");
        }
    }
}
