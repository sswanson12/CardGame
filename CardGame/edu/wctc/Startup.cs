using System;
using System.Collections.Generic;
using CardGame.edu.wctc.Objects;
using CardGame.edu.wctc.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CardGame.edu.wctc
{
    internal static class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<IGameService, GameService>();
            
            services.AddTransient<IList<ICard>, List<ICard>>();
            services.AddTransient<IList<IPlayer>, List<IPlayer>>();
            services.AddTransient<IDeck, Deck>();
            services.AddTransient<IDealer, Dealer>();
            services.AddTransient<IHand, Hand>();
            services.AddTransient<IPlayer, Player>();

            return services.BuildServiceProvider();
        }
    }
}