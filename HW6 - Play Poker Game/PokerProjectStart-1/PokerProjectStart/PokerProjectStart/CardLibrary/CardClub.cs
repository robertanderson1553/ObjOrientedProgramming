using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardLibrary
{
    public class CardClub : SuperCard
    {
        private Suit _CardSuit = Suit.Club;

        public override Suit CardSuit { get; set; }

        public CardClub() { }
        public CardClub(Rank clubRank)
        {
            this.CardRank = clubRank;
            this.CardSuit = _CardSuit;
        }

        public override void Display()
        {
            // Code to Display a club card...
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(CardRank + " of " + _CardSuit + "s ♣");
            Console.ResetColor();
        }

    }
}
