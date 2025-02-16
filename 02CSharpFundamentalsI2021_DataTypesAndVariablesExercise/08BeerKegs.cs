using System;

namespace _08BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            string biggestKegModel = string.Empty;
            double biggestKegVolume = 0;
            int kegsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < kegsCount; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                
                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;
                if (kegVolume > biggestKegVolume)
                {
                    biggestKegVolume = kegVolume;
                    biggestKegModel = kegModel;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
