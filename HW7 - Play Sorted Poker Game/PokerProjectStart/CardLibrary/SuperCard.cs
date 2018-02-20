using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    // Card Deck suits
    public enum Suit
    {
        Club = 1,   // value = 1
        Diamond,    // value = 2
        Heart,      // value = 3
        Spade       // value = 4
    }

    // Card Deck rank by card value
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

    public abstract class SuperCard : IComparable<SuperCard>
    {
        public Rank CardRank { get; set; }
        public abstract Suit CardSuit { get; set; }
        public abstract void Display();

        // Sort cards by Suit and Rank
        // The order of suits from high to low is: Spades, Hearts, Diamonds, and Clubs
        public int CompareTo(SuperCard other)
        {
            // Current card suit is larger than value passed in parameter
            if (((int)(other.CardSuit)) < ((int)(this.CardSuit)))
            {
                return 1;              
            }
            // Current card suit is smaller than value passed in parameter
            else if (((int)(other.CardSuit)) > ((int)(this.CardSuit)))
            {
                return -1;             
            }
            // Current card suit is equal to value passed in parameter
            else
            {
                // Current card rank is larger than value passed in parameter 
                if (((int)(other.CardRank)) < ((int)(this.CardRank)))
                {
                    return 1;          
                }
                // Current card rank is smaller than value passed in parameter
                else if (((int)(other.CardRank)) > ((int)(this.CardRank)))
                {
                    return -1;         
                }
                // Current card rank is equal to value passed in parameter
                else
                {
                    return 0;          
                }
            }
        }
    }
}
