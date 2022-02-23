namespace ConsoleApp1;

internal class SomeService : ISomeService
{
    private readonly ICustomLogger _customLogger;

    public SomeService(ICustomLogger customLogger)
    {
        ArgumentNullException.ThrowIfNull(customLogger, nameof(customLogger));

        _customLogger = customLogger;
    }

    void ISomeService.DoWork()
    {
        _customLogger.Log("start");

        Console.WriteLine("working...");

        _customLogger.Log("end");
    }
}
