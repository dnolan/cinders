using Cinders.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Cinders.Tests
{
    public class GameTests
    {
        [Fact]
        public void SetNextPlayer_NextAboveActive()
        {
            var g = new Game();
            g.AddPlayer(new Player("1"));
            g.AddPlayer(new Player("2"));
            g.CurrentPlayer = 1;

            g.SetNextPlayer();

            Assert.Equal(2, g.CurrentPlayer);
        }

        [Fact]
        public void SetNextPlayer_NextBelowActive()
        {
            var g = new Game();
            g.AddPlayer(new Player("1"));
            g.AddPlayer(new Player("2"));
            g.AddPlayer(new Player("3") { Active = false });

            g.CurrentPlayer = 2;

            g.SetNextPlayer();

            Assert.Equal(1, g.CurrentPlayer);
        }

        [Fact]
        public void SetNextPlayer_SkipNext()
        {
            var g = new Game();
            g.AddPlayer(new Player("1"));
            g.AddPlayer(new Player("2") { Active = false });
            g.AddPlayer(new Player("3"));

            g.CurrentPlayer = 1;

            g.SetNextPlayer();

            Assert.Equal(3, g.CurrentPlayer);
        }

        [Fact]
        public void SetNextPlayer_NoOneElseActive()
        {
            var g = new Game();
            g.AddPlayer(new Player("1"));
            g.AddPlayer(new Player("2") { Active = false });

            g.CurrentPlayer = 1;

            g.SetNextPlayer();

            Assert.Equal(1, g.CurrentPlayer);

        }

        [Fact]
        public void SetNextPlayer_CycleAllPlayers()
        {
            var g = new Game();
            g.AddPlayer(new Player("1"));
            g.AddPlayer(new Player("2"));
            g.AddPlayer(new Player("3"));
            g.AddPlayer(new Player("4"));

            g.CurrentPlayer = 1;

            g.SetNextPlayer();
            Assert.Equal(2, g.CurrentPlayer);
            g.SetNextPlayer();
            Assert.Equal(3, g.CurrentPlayer);
            g.SetNextPlayer();
            Assert.Equal(4, g.CurrentPlayer);
            g.SetNextPlayer();
            Assert.Equal(1, g.CurrentPlayer);
        }
    }
}
