using Lifetime_tester;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                

                services.AddTransient<Service>();
                services.AddTransient<Repository>();
            }).Build();

        var runner = ActivatorUtilities.CreateInstance<Runner>(host.Services);
        runner.Run();
    }
}