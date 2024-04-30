using Microsoft.Extensions.Logging;

namespace ZiggyRafiq.CodeExample04.InversionOfControl;

public class ExampleService
{
    private readonly ILogger _logger;

    public ExampleService(ILogger logger)
    {
        _logger = logger;
    }

    public void DoSomething()
    {
        _logger.LogInformation("Doing something...");
    }
}
