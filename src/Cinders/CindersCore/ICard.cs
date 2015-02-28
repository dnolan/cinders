
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public interface ICard
    {
        void Discard(Player player);
        CardType CardType { get; }

        // Guard, choose target player and player.HasCardType
        // Priest, choose target player and GetCards
        // Baron, choose target player and Compare
        // Handmaid, cannot attack current
        // Prince, choose target and discard, check target discard
        // King, choose target and swap
        // Countess, check hand
        // Princess, check discard
    }
}
