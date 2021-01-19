using System;

namespace _10PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int pokedTargetsCount = 0;
            int currentPowerN = powerN;
            while (currentPowerN >= distanceM)
            {
                currentPowerN -= distanceM;
                pokedTargetsCount++;                

                if (currentPowerN == powerN * 0.5 && exhaustionFactorY != 0 /* && currentPowerN / exhaustionFactorY != 0 */)
                {
                    currentPowerN /= exhaustionFactorY;
                }
            }

            Console.WriteLine(currentPowerN);
            Console.WriteLine(pokedTargetsCount);
        }
    }
}
