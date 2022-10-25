using System;
using System.Collections.Generic;
using CardGame.edu.wctc.Objects;

namespace CardGame.edu.wctc.Services
{
    public class GameService : IGameService
    {
        private readonly IDealer _dealer;
        private readonly IList<IPlayer> _players;
        private readonly HandFactory _handFactory;

        public GameService(IDealer dealer, IList<IPlayer> players)
        {
            _handFactory = new HandFactory();
            _dealer = dealer;
            _players = players;
        }

        public void Invoke()
        {
            Console.WriteLine("How many players are there?");

            int response;

            while (!int.TryParse(Console.ReadLine(), out response))
            {
                Console.WriteLine("Invalid input. Ensure you're inputting a number.");
            }

            for (var i = 1; i < response; i++)
            {
                //I was doing the dependency injection before I realized I don't know how to do this without the "new"s
                //quite yet!
                _players.Add(new Player(_handFactory.CreateHand()));
            }

            foreach (var player in _players)
            {
                _dealer.DealHand(player.GetHand());
                Console.WriteLine($"Player {_players.IndexOf(player) + 1}:\n" +
                                  $"{player.ShowHand()}");
            }
        }

        private class HandFactory
        {
            public IHand CreateHand()
            {
                return new Hand(new List<ICard>());
            }
        }
    }
}