using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace APIGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)

            .ConfigureAppConfiguration((host, config) =>
            {
                config.AddJsonFile("ocelot.json");
            })

            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseUrls("http://*:9002");
                webBuilder.UseStartup<Startup>();
            });
    }
}