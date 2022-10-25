using System;
using CardGame.edu.wctc;
using CardGame.edu.wctc.Services;
using Microsoft.Extensions.DependencyInjection;

try
{
    var serviceProvider = Startup.ConfigureServices();
    var service = serviceProvider.GetService<IGameService>();

    service?.Invoke();
}
catch (Exception e)
{
    Console.Error.WriteLine(e);
}