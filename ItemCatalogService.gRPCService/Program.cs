using ItemCatalogService.Data.DataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ItemCatalogService.gRPCService.Extensions;

namespace ItemCatalogService.gRPCService
{
    public class Program
    {        

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().MigrateDatabase<ItemContext>().Run();
        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
