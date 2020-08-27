using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DucthTreat.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore;

namespace DucthTreat
{
    public class Program
    {
        [Obsolete]
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            SeedDb(host);

            host.Run();
        }

        [Obsolete]
        private static void SeedDb(IWebHost host)
        {
            var scopeFactory = host.Services.GetService<IServiceScopeFactory>();

            using var scope = scopeFactory.CreateScope();
            var seeder = scope.ServiceProvider.GetService<DutchSeeder>();
            seeder.SeedAsync().Wait();

        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(SetupConfiguration)
            .UseStartup<Startup>()
            .Build();

        private static void SetupConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder builder)
        {
            // Removing the default configuration option
            builder.Sources.Clear();
            builder.AddJsonFile("config.json", false, true)
               .AddEnvironmentVariables();
        }
    }
}
