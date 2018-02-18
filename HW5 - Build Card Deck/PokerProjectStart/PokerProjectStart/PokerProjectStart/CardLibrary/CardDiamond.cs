using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardDiamond : SuperCard
    {
        private Suit _CardSuit = Suit.Diamond;

        public override Suit CardSuit { get; set; }

        public CardDiamond() { }
        public CardDiamond(Rank diamondRank)
        {
            this.CardRank = diamondRank;
            this.CardSuit = _CardSuit;
        }
    }
}
