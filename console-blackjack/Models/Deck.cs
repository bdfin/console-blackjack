using ConsoleBlackjack.Common;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ConsoleBlackjack.Models
{
    public class Deck
    {
        public IList<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
        }

        public void Build()
        {
            foreach (var suit in CardConstants.Suits)
            {
                Cards.Add(new Card
                {
                    Suit = suit,
                    Name = CardConstants.Ace,
                    Value = 11
                });

                for (int i = 2; i < 11; i++)
                {
                    Cards.Add(new Card
                    {
                        Suit = suit,
                        Name = i.ToString(),
                        Value = i
                    });
                }

                Cards.Add(new Card
                {
                    Suit = suit,
                    Name = CardConstants.Jack,
                    Value = 10
                });

                Cards.Add(new Card
                {
                    Suit = suit,
                    Name = CardConstants.Queen,
                    Value = 10
                });

                Cards.Add(new Card
                {
                    Suit = suit,
                    Name = CardConstants.King,
                    Value = 10
                });
            }
        }

        public void Shuffle()
        {
            var provider = new RNGCryptoServiceProvider();

            int n = Cards.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }
    }
}
