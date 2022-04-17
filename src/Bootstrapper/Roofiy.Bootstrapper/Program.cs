using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Roofiy.Shared.Infrastructure.Logging;
using Roofiy.Shared.Infrastructure.Modules;

namespace Roofiy.Bootstrapper;

public class Program
{
    public static Task Main(string[] args)
        => CreateHostBuilder(args).Build().RunAsync();

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
            .ConfigureModules()
            .UseLogging();
}