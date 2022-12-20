using FanatecStockNotifier.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FanatecStockNotifier.Functions;

public class StockNotifier
{
    private readonly ILogger _logger;

    public StockNotifier(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<StockNotifier>();
    }

    [Function(nameof(StockNotifier))]
    public void Run([TimerTrigger("0 * */1 * * *")] MyInfo myTimer)
    {
        _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

        //Do webscraping magic

        _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
    }
}