namespace CardGame.edu.wctc.Objects
{
    public class Card : ICard
    {
        private readonly string _suit;

        private readonly int _face;

        public Card(string suit, int face)
        {
            _face = face;
            _suit = suit;
        }

        public override string ToString()
        {
            //Intellisense thing. I like putting them in though because I often remember them after seeing it for the
            //First time.
            return _face switch
            {
                1 => $"Ace of {_suit}",
                11 => $"Jack of {_suit}",
                12 => $"Queen of {_suit}",
                13 => $"King of {_suit}",
                _ => $"{_face} of {_suit}"
            };
        }
    }
}