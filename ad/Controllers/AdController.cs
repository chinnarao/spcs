using ad.services;
using common.constants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace ad.Controllers
{
    //https://github.com/aspnet/Docs/blob/master/aspnetcore/fundamentals/logging/index/sample2/Controllers/TodoController.cs
    [Route("[controller]/[action]")]
    public class AdController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly IAdService _adService;

        public AdController(IConfiguration configuration, ILogger<AdController> logger, IAdService adService)
        {
            _configuration = configuration;
            _logger = logger;
            _adService = adService;
        }

        [HttpGet]
        public IActionResult PostAd()
        {
            int cacheDays = Convert.ToInt32(_configuration["InMemoryCacheDays"]);
            string fileName = _configuration["AdHtmlTemplateFileName"];
            string fileContent = _adService.GetAdHtmlFileTemplateContent(fileName, cacheDays);
            return Ok(new { Name = "Chinna", Email = "chinnarao@live.com" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok( new { Name = "Chinna", Email = "chinnarao@live.com" });
        }
    }
}