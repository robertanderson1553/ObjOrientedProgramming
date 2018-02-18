using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardSet
    {
        // an array of SuperCard's
        public SuperCard[] CardArray { get; set; }

        public CardSet()
        {
            // allocate memory for 52 SuperCard's (1-53)
            CardArray = new SuperCard[53];


            //Nested loop, which fills the array of 52 elements of this new array with one of each card type.  
            //That’s 13 spades from deuce to Ace, 13 hearts, etc, so that cardArray has all unique 52 cards.
            int cardCount = 0; //Card counter 1-52, default to zero

            //loop through the card suit's as defined in enum
            foreach (Suit mySuit in Enum.GetValues(typeof(Suit))) //Suit - Club, Diamond, Heart, Spade
            {
                //loop through the card rank's as defined in enum
                foreach (Rank myRank in Enum.GetValues(typeof(Rank))) //Rank - Deuce, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
                {
                    cardCount++;

                    switch (mySuit)
                    {
                        case Suit.Club:
                            CardArray[cardCount] = new CardClub(myRank);    //creates a Club card
                            break;
                        case Suit.Diamond:
                            CardArray[cardCount] = new CardDiamond(myRank); //creates a Diamond card
                            break;
                        case Suit.Heart:
                            CardArray[cardCount] = new CardHeart(myRank);   //creates a Heart card
                            break;
                        case Suit.Spade:
                            CardArray[cardCount] = new CardSpade(myRank);   //creates a Spade card
                            break;
                    }
                }
            }
        }
    }
}
