
namespace Cinders.Core
{
    public class CardPrincess : ICard
    {
        public void Discard(Player player)
        {
            player.IsOut = true;
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
