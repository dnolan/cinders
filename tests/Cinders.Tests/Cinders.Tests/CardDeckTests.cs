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
        public void CardDeck_BuildDeck()
        {
            var cd = new CardDeck();
            cd.BuildDeck();
        }
    }
}
