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
    }
}
