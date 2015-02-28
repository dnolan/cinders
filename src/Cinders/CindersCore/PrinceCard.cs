using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class PrinceCard : IAttackCard, ICard
    {
        public void Discard(Player player)
        {
            throw new NotImplementedException();
        }

        public bool AttackPlayer(Player player)
        {
            if (player.AllowsAttack)
            {
                player.Discard();
            }
        }


        public CardType CardType
        {
            get { return CardType.Prince; }
        }
    }
}
