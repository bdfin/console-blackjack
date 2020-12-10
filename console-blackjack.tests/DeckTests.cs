using ConsoleBlackjack.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ConsoleBlackjack.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void HasAllCards()
        {
            var deck = new Deck();
            deck.Build();

            Assert.IsTrue(deck.Cards.Count is 52);
        }

        [TestMethod]
        public void HasBeenShuffled()
        {
            var orderedDeck = new Deck();
            orderedDeck.Build();

            var shuffledDeck = new Deck();
            shuffledDeck.Build();
            shuffledDeck.Shuffle();

            Assert.IsFalse(orderedDeck.Cards.SequenceEqual(shuffledDeck.Cards));
        }

        [TestMethod]
        public void HasDifferentCardOrder()
        {
            bool match = false;

            var deck1 = new Deck();
            deck1.Build();
            deck1.Shuffle();

            for (int i = 0; i < 10000000; i++)
            {
                var deck2 = new Deck();
                deck2.Build();
                deck2.Shuffle();

                if (deck1.Cards.SequenceEqual(deck2.Cards))
                    match = true;
            }

            Assert.IsFalse(match);
        }
    }
}
