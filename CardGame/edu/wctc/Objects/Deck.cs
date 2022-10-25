using System;
using System.Collections.Generic;

namespace CardGame.edu.wctc.Objects
{
    public class Deck : IDeck
    {
        private readonly IList<ICard> _cards;

        public Deck(IList<ICard> cards)
        {
            _cards = cards;
            
            string[] suits = {"Spades", "Clubs", "Diamonds", "Hearts"};

            int[] faces = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

            foreach (var suit in suits)
            {
                foreach (var face in faces)
                {
                    _cards.Add(new Card(suit, face));
                }
            }
        }

        public ICard DrawCard()
        {
            var randomNum = new Random().Next(0, _cards.Count);

            var card = _cards[randomNum];

            _cards.Remove(card);

            return card;
        }
    }
}