using System;
using System.Collections.Generic;
using System.Linq;

namespace _06CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                PlayCards(firstPlayerCards, secondPlayerCards);               
            }

            if (firstPlayerCards.Count > 0)
            {
                Console.WriteLine("First player wins! Sum: " + firstPlayerCards.Sum());
            }
            else if (secondPlayerCards.Count > 0)
            {
                Console.WriteLine("Second player wins! Sum: " + secondPlayerCards.Sum());
            }
        }

        private static void PlayCards(List<int> firstPlayerCards, List<int> secondPlayerCards)
        {
            int firstPlayerCard = firstPlayerCards[0];
            firstPlayerCards.RemoveAt(0);

            int secondPlayerCard = secondPlayerCards[0];
            secondPlayerCards.RemoveAt(0);

            if (firstPlayerCard > secondPlayerCard)
            {
                firstPlayerCards.Add(firstPlayerCard);
                firstPlayerCards.Add(secondPlayerCard);
            }
            else if (firstPlayerCard < secondPlayerCard)
            {
                secondPlayerCards.Add(secondPlayerCard);
                secondPlayerCards.Add(firstPlayerCard);
            }
        }
    }
}
