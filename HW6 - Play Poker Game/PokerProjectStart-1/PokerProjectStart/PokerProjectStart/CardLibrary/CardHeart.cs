using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardHeart : SuperCard
    {
        private Suit _CardSuit = Suit.Heart;

        public override Suit CardSuit { get; set; }

        public CardHeart() { }
        public CardHeart(Rank heartRank)
        {
            this.CardRank = heartRank;
            this.CardSuit = _CardSuit;
        }

        public override void Display()
        {
            // Code to Display a heart card...
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(CardRank + " of " + _CardSuit + "s ♥");
            Console.ResetColor();
        }

    }
}
