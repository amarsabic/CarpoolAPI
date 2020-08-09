using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Carpool.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // CreateHostBuilder(args).Build().Run();

            //var hosts = CreateHostBuilder(args).Build();

            //using (var scope = hosts.Services.CreateScope())
            //{
            //    var service = scope.ServiceProvider.GetRequiredService<CarpoolContext>();
            //    service.Database.Migrate();
            //    Seeding.SeedDatabase(service);
            //}

            //hosts.Run();

            var hosts = CreateHostBuilder(args).Build();
            using (var scope = hosts.Services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<CarpoolContext>();
                service.Database.Migrate();
            }

            hosts.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
