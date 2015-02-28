using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinders.Core
{
    public class CardDeck
    {
        public Dictionary<CardType, int> CardCounts { get; private set; }
        public CardType[] Cards { get; set; }
        public const int TotalCards = 16;

        public CardDeck()
        {
            CardCounts = new Dictionary<CardType, int>()
            {
                {CardType.Guard, 5}, 
                {CardType.Priest, 2}, 
                {CardType.Baron, 2}, 
                {CardType.Handmaid, 2},
                {CardType.Prince, 2},
                {CardType.King, 1},
                {CardType.Countess, 1},
                {CardType.Princess, 1}
            };
        }

        public void BuildDeck()
        {
            var cards = new CardType[TotalCards];
            var i = 0;

            foreach (var row in CardCounts)
            {
                for (var j = 1; j <= row.Value; j++)
                {
                    cards[i] = row.Key;
                    i++;
                }
            }

            Cards = Shuffle(cards);
        }

        public static CardType[] Shuffle(IEnumerable<CardType> cards)
        {
            var remainingCards = new List<CardType>(cards);
            var rand = new Random();
            var shuffledCards = new CardType[TotalCards];
            for (var i = 0; i <= TotalCards; i++)
            {
                var pick = rand.Next(1, remainingCards.Count);
                shuffledCards[i] = remainingCards[pick];
                remainingCards.RemoveAt(pick);
            }
            return shuffledCards;
        }
    }
}
