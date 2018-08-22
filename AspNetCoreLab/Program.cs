using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace AspNetCoreLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Output("Application Start");
            var webHost = BuildWebHost(args);
            Output("Run WebHost");
            webHost.Run();
            Output("Application - End");
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            Output("Create WebHost Builder");
            var webHostBuilder = WebHost.CreateDefaultBuilder(args)
            .ConfigureServices((service) =>
            {
                Output("WebHostBuilder.ConfiureServices - Called");
            })
            .Configure(app =>
            {
                Output("WebHostBuilder.Configure - Called");
            })
            .UseStartup<Startup>();

            Output("Build WebHost");
            var webHost = webHostBuilder.Build();
            return webHost;
        }

        public static void Output(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {message}");
        }
    }
}
