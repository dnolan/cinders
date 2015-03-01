using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public int ShuffleSeed { get; set; }

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

        public void BuildDeck(bool shuffle = true)
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

            if (shuffle)
            {
                Cards = Shuffle(cards);
            }
            else
            {
                Cards = cards;
            }
        }

        public CardType[] Shuffle(IEnumerable<CardType> cards, int? seed = null)
        {
            var remainingCards = new List<CardType>(cards);

            ShuffleSeed = seed ?? (int)DateTime.Now.Ticks & 0x0000FFFF;

            Debug.WriteLine("Seed {0}", ShuffleSeed);

            var rand = new Random(ShuffleSeed);

            var j = 0;
            foreach (var card in remainingCards)
            {
                Debug.WriteLine("{0} : {1}", card, j++);
            }

            var shuffledCards = new CardType[TotalCards];
            for (var i = 0; i < TotalCards; i++)
            {
                Debug.WriteLine("Iteration: {0}", i);

                var pick = rand.Next(0, remainingCards.Count);

                Debug.WriteLine("Pick: {0} from {1}", pick, remainingCards.Count - 1);

                shuffledCards[i] = remainingCards[pick];
                Debug.WriteLine(remainingCards[pick]);
                remainingCards.RemoveAt(pick);
            }

            return shuffledCards;
        }
    }
}
