using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleBlackjack.Common
{
    public class Constants
    {

    }

    public class CardConstants
    {
        public const string Ace = "Ace";
        public const string One = "1";
        public const string Two = "2";
        public const string Three = "3";
        public const string Four = "4";
        public const string Five = "5";
        public const string Six = "6";
        public const string Seven = "7";
        public const string Eight = "8";
        public const string Nine = "9";
        public const string Ten = "10";
        public const string Jack = "Jack";
        public const string Queen = "Queen";
        public const string King = "King";

        public static readonly IList<string> Suits = new ReadOnlyCollection<string>(
            new List<string>
            {

                { "Clubs" },
                { "Diamonds" },
                { "Hearts" },
                { "Spades" }
            });
    }
}
