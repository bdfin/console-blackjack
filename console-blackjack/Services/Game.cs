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

        public static void Initialise()
        {
            ConsoleText.Scroll("Welcome to Console Blackjack!");
            ConsoleText.Scroll("Building deck.");
            ConsoleText.Scroll("Shuffling cards.");
            ConsoleText.Scroll("Dealing cards.");

            Deck = new Deck();
            Deck.Build();
            Deck.Shuffle();
        }
    }
}
