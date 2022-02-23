using static System.Console;

namespace ConsoleApp1;

internal class ConsoleLogger : ICustomLogger
{
    void ICustomLogger.Log(string message) => WriteLine(message);
}