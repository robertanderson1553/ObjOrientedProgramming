using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public enum Suit
    {
        Club = 1,   // value = 1
        Diamond,    // value = 2
        Heart,      // value = 3
        Spade       // value = 4
    }

    public enum Rank
    {
        Deuce = 2,
        Three = 3,
        Four =4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }

    public abstract class SuperCard
    {
        public Rank CardRank { get; set; }
        public abstract Suit CardSuit { get; set; }
    }
}
