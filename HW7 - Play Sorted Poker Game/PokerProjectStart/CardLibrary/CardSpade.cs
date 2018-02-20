using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardSpade : SuperCard
    {
        private Suit _CardSuit = Suit.Spade;

        public override Suit CardSuit { get; set; }

        public CardSpade() {}
        public CardSpade(Rank spadeRank)
        {
            this.CardRank = spadeRank;
            this.CardSuit = _CardSuit;
        }

        public override void Display()
        {
            // Code to Display a Spade card...
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(CardRank + " of " + _CardSuit + "s ♠");
            Console.ResetColor();
        }
    }
}
