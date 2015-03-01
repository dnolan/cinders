using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cinders.Core
{
    public class Game
    {
        public List<Player> Players { get; private set; }

        public int IgnoredCards { get; private set; }
        public byte CurrentPlayer { get; set; }
        public byte TotalPlayers { get; set; }
        public const byte MaxPlayers = 4;

        public Game()
        {
            IgnoredCards = 1;
            Players = new List<Player>();
        }

        public bool AddPlayer(Player player)
        {
            if (TotalPlayers >= 4)
            {
                return false;
            }

            Players.Add(player);
            player.Id = (byte)Players.Count;
            TotalPlayers++;
            return true;
        }

        public void PlayCard(ICard card, Player target = null)
        {
        }

        public void SetNextPlayer()
        {
            var nextPlayer = Players.Where(p => p.Active && p.Id != CurrentPlayer).ToList();
            
            if (nextPlayer.Any(p => p.Id > CurrentPlayer))
            {
                CurrentPlayer = nextPlayer.Where(p => p.Id > CurrentPlayer).Min(p => p.Id);
            }
            else if (nextPlayer.Any(p => p.Id < CurrentPlayer))
            {
                CurrentPlayer = nextPlayer.Where(p => p.Id < CurrentPlayer).Min(p => p.Id);
            }            
        }

        public void SetupGame()
        {
            if (Players.Count <= 1)
            {
                throw new Exception("Insufficient Players");
            }

            if (Players.Count == 2)
            {
                IgnoredCards = 3;
            }
        }
    }
}
