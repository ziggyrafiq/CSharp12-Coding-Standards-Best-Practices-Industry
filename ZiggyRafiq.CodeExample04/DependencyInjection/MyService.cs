using Microsoft.Extensions.Logging;

namespace ZiggyRafiq.CodeExample04.DependencyInjection;
public class MyService
{
    private readonly ILogger _logger;

    public MyService(ILogger logger)
    {
        _logger = logger;
    }

    public void DoSomething()
    {
        _logger.LogInformation("Doing something...");
    }
}
