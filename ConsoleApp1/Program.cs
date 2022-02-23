using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

IServiceProvider serviceProvider = StartUp.ConfigureServices();

ISomeService someService = serviceProvider.GetRequiredService<ISomeService>();

someService.DoWork();