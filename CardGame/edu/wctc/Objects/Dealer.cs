namespace CardGame.edu.wctc.Objects
{
    public class Dealer : IDealer
    {
        private readonly IDeck _deck;

        public Dealer(IDeck deck)
        {
            _deck = deck;
        }


        public void DealHand(IHand hand)
        {
            for (var i = 0; i < hand.MaxHandSize(); i++)
            {
                hand.AddCard(_deck.DrawCard());
            }
        }
    }
}