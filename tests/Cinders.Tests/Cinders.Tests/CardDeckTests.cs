using Cinders.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Cinders.Tests
{
    
    public class CardDeckTests
    {
        [Fact]
        public void CardDeck_InitCardCounts()
        {
            var cd = new CardDeck();
            Assert.Equal(8, cd.CardCounts.Count);
        }

        [Fact]
        public void CardDeck_BuildDeckDefault()
        {
            var cd = new CardDeck();
            Assert.DoesNotThrow(() => cd.BuildDeck());
        }

        [Fact]
        public void CardDeck_Shuffle_ExpectedSeed()
        {
            var cd = new CardDeck();

            cd.BuildDeck(false);
            var cards = cd.Shuffle(cd.Cards, 16958);

            Assert.NotEmpty(cards);
            Assert.Equal(16, cards.Count());
            Assert.Equal(CardType.Guard, cards[0]);
            Assert.Equal(CardType.Handmaid, cards[1]);
            Assert.Equal(CardType.Guard, cards[2]);
            Assert.Equal(CardType.Guard, cards[3]);
            Assert.Equal(CardType.Handmaid, cards[4]);
            Assert.Equal(CardType.Guard, cards[5]);
            Assert.Equal(CardType.Guard, cards[6]);
            Assert.Equal(CardType.Priest, cards[7]);
            Assert.Equal(CardType.Princess, cards[8]);
            Assert.Equal(CardType.Prince, cards[9]);
            Assert.Equal(CardType.King, cards[10]);
            Assert.Equal(CardType.Countess, cards[11]);
            Assert.Equal(CardType.Baron, cards[12]);
            Assert.Equal(CardType.Prince, cards[13]);
            Assert.Equal(CardType.Priest, cards[14]);
            Assert.Equal(CardType.Baron, cards[15]);
        }
    }
}
