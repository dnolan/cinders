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
        
        public List<Player> Players { get; set; }
        
        public int IgnoredCards { get; private set; }

        public Game()
        {
            IgnoredCards = 1;
            Players = new List<Player>();
           
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
