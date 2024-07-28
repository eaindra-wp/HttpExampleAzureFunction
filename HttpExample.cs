using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpExample
{
    public class HttpExample(ILogger<HttpExample> logger)
    {
        private readonly ILogger<HttpExample> _logger = logger;

        [Function("HttpExample")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anynymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
