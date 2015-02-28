using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinders.Core
{
    public class Player
    {
        public string Name { get; set; }
        public ICard HeldCard { get; set; }
        public ICard NewCard { get; set; }
        public ICard PlayedCard { get; set; }

        public bool IsOut { get; set; }

        public bool AllowsAttack { get; set; }

        internal void Discard()
        {
            HeldCard.Discard(this);
        }

        public void PlayCard(CardType card, Player player = null)
        {
            
        }
    }
}
