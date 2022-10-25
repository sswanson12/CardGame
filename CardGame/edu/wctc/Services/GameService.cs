using System;
using System.Collections.Generic;
using CardGame.edu.wctc.Objects;

namespace CardGame.edu.wctc.Services
{
    public class GameService : IGameService
    {
        private readonly IDealer _dealer;
        private readonly IList<IPlayer> _players;

        public GameService(IDealer dealer, IList<IPlayer> players)
        {
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
                _players.Add(new Player(new Hand(new List<ICard>())));
            }

            foreach (var player in _players)
            {
                _dealer.DealHand(player.GetHand());
                Console.WriteLine($"Player {_players.IndexOf(player) + 1}:\n" +
                                  $"{player.ShowHand()}");
            }
        }
    }
}