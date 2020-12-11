using ConsoleBlackjack.Common;
using ConsoleBlackjack.Helpers;
using System.Collections.Generic;

namespace ConsoleBlackjack.Models
{
    public class Player
    {
        public List<Card> Cards { get; set; }
        public decimal Chips { get; set; }
        public int HandsWon { get; set; }

        public Player()
        {
            Chips = (decimal)StartingChips.Low;
            Cards = new List<Card>();
            HandsWon = 0;
        }

        public void Bet(decimal amount)
        {
            if (amount > Chips)
            {
                ConsoleExtention.WriteErrorMessage(BettingMessages.InsufficientChips);
            }
            else
            {
                Chips -= amount;
            }
        }
    }
}
