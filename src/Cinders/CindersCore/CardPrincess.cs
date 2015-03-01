
namespace Cinders.Core
{
    public class CardPrincess : ICard
    {
        public void Discard(Player player)
        {
            player.Active = false;
        }


        public CardType CardType
        {
            get
            {
                return CardType.Princess;
                ;
            }
        }
    }
}
