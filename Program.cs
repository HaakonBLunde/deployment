using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using sykeplayer_1.Data;
using sykeplayer_1.Models;

namespace sykeplayer_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
            
                var services = scope.ServiceProvider;
                    
                
                // Get our database context from the service provider
                var context = services.GetRequiredService<ApplicationDbContext>();
                // Get the environment so we can check if this is running in development or otherwise
                var environment = services.GetService<IHostEnvironment>();

              var um = services.GetRequiredService<UserManager<ApplicationUser>>();

                var rm = services.GetRequiredService<RoleManager<IdentityRole>>();

                // Initialise the database using the initializer from Data/ApplicationDbInitializer.cs
                questionDbInitializer.Initialize(context, um, rm);
            }
                
            host.Run();
            
                
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
