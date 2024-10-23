using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FizzBuzzApp.Domain.Interfaces;
using FizzBuzzApp.Services;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddScoped<IFizzBuzzService, FizzBuzzService>();
    })
    .Build();

host.Run();