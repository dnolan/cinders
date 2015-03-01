using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinders.Core
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            Active = true;
        }
        public string Name { get; set; }
        public ICard HeldCard { get; set; }
        public ICard NewCard { get; set; }
        public ICard PlayedCard { get; set; }

        public bool Active { get; set; }

        public bool AllowsAttack { get; set; }

        internal void Discard()
        {
            HeldCard.Discard(this);
        }

        public void PlayCard(ICard card, Player player = null)
        {
            PlayedCard = card;
        }

        public byte Id { get; set; }
    }
}
