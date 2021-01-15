using System;

namespace _10RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            decimal rageExpensesAmount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpensesAmount += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    rageExpensesAmount += mousePrice;
                }

                if (i % 6 == 0)
                {
                    rageExpensesAmount += keyboardPrice;
                }

                if (i % 12 == 0)
                {
                    rageExpensesAmount += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {rageExpensesAmount:f2} lv.");
        }
    }
}
