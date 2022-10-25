namespace CardGame.edu.wctc.Objects
{
    public class Player : IPlayer
    {
        private readonly IHand _hand;

        public Player(IHand hand)
        {
            _hand = hand;
        }


        public string ShowHand()
        {
            return $"{_hand}";
        }

        public IHand GetHand()
        {
            return _hand;
        }
    }
}