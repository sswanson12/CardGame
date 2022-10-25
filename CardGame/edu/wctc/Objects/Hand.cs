using System.Collections.Generic;

namespace CardGame.edu.wctc.Objects
{
    public class Hand : IHand
    {
        private const int MaximumHandSize = 5;

        private readonly IList<ICard> _cards;

        public Hand(IList<ICard> cards)
        {
            _cards = cards;
        }

        public bool AddCard(ICard card)
        {
            if (_cards.Count >= MaximumHandSize)
            {
                return false;
            }
            
            _cards.Add(card);
            return true;
        }

        public int MaxHandSize()
        {
            return MaximumHandSize;
        }

        public override string ToString()
        {
            var returnString = "";

            foreach (var card in _cards)
            {
                returnString += $"{card}\n";
            }

            return returnString;
        }
    }
}