using common.constants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ad.Controllers
{
    //https://github.com/aspnet/Docs/blob/master/aspnetcore/fundamentals/logging/index/sample2/Controllers/TodoController.cs
    [Route("api/[controller]"), Produces("application/json")]
    public class GoogleStorageController : ControllerBase
    {
        private readonly ILogger _logger;

        public GoogleStorageController(ILogger<GoogleStorageController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation(LoggingEvents.LIST_ITEMS, "Listing all items");
            return Ok();
        }
    }
}