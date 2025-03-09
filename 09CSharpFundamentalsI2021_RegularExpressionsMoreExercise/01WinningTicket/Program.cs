using System;
using System.Text.RegularExpressions;

namespace _01WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Regex atRegex = new Regex(@"@{6,10}");
            Regex hashRegex = new Regex(@"#{6,10}");
            Regex dollarRegex = new Regex(@"\${6,10}");
            Regex caretRegex = new Regex(@"\^{6,10}");

            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                bool winsAt = CheckForSymbol(ticket, atRegex);
                if (winsAt)
                {
                    continue;
                }

                bool winsHash = CheckForSymbol(ticket, hashRegex);
                if (winsHash)
                {
                    continue;
                }

                bool winsDollar = CheckForSymbol(ticket, dollarRegex);
                if (winsDollar)
                {
                    continue;
                }

                bool winsCaret = CheckForSymbol(ticket, caretRegex);
                if (winsCaret)
                {
                    continue;
                }

                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }

        private static bool CheckForSymbol(string ticket, Regex symbolRegex)
        {
            string firstHalf = ticket.Substring(0, 10);
            string secondHalf = ticket.Substring(10);

            Match matchFirstHalf = symbolRegex.Match(firstHalf);
            Match matchSecondHalf = symbolRegex.Match(secondHalf);
            int symbolMatchesLength = Math.Min(matchFirstHalf.Value.Length, matchSecondHalf.Value.Length);
            
            if (symbolMatchesLength == 10)
            {
                string symbol = matchFirstHalf.Value[0].ToString();
                Console.WriteLine($"ticket \"{ticket}\" - 10{symbol} Jackpot!");
                
                return true;
            }
            else if (symbolMatchesLength >= 6)
            {
                string symbol = matchFirstHalf.Value[0].ToString();
                Console.WriteLine($"ticket \"{ticket}\" - {symbolMatchesLength}{symbol}");
                
                return true;
            }

            return false;
        }
    }
}
