using common.constants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ad.Controllers
{
    //https://github.com/aspnet/Docs/blob/master/aspnetcore/fundamentals/logging/index/sample2/Controllers/TodoController.cs
    [Route("api/[controller]"), Produces("application/json")]
    public class AdController : ControllerBase
    {
        private readonly ILogger _logger;

        public AdController(ILogger<AdController> logger)
        {
            _logger = logger;
        }

        [HttpGet( Name = "GetAll")]
        public IActionResult GetAll()
        {
            _logger.LogInformation(LoggingEvents.LIST_ITEMS, "Listing all items");
            return Ok( new { Name = "Chinna", Email = "chinnarao@live.com" });
        }
    }
}