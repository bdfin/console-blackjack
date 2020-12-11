using ConsoleBlackjack.Common;
using ConsoleBlackjack.Helpers;
using ConsoleBlackjack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackjack.Services
{
    public static class Game
    {
        private static Deck Deck;

        public static void Welcome()
        {
            ConsoleExtention.Scroll(StandardMessages.Welcome);
            Console.Clear();

            ConsoleExtention.Continue();
        }

        public static void Initialise()
        {
            ConsoleExtention.Scroll(StandardMessages.ShufflingCards);

            Deck = new Deck();
            Deck.Initialise();

            ConsoleExtention.Scroll(StandardMessages.DealingCards);
            Console.Clear();

            ConsoleExtention.Continue();
        }
    }
}
