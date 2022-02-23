using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1;

internal static class StartUp
{
    public static IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddTransient<ICustomLogger, ConsoleLogger>();
        services.AddTransient<ISomeService, SomeService>();

        IServiceProvider serviceProvider = services.BuildServiceProvider();

        return serviceProvider;
    }
}