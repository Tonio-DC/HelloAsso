using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace HelloAsso.AggregateOrderItems
{
    public class HelloAssoHttpTrigger
    {
        private readonly ILogger<HelloAssoHttpTrigger> _logger;

        public HelloAssoHttpTrigger(ILogger<HelloAssoHttpTrigger> logger)
        {
            _logger = logger;
        }

        [Function("HelloAssoHttpTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
