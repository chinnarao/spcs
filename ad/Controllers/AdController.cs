using ad.services;
using common.constants;
using common.admodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using extensions;

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

        [HttpPost]
        public IActionResult PostAd([FromBody]Method_PostAd data)
        {
            if (string.IsNullOrWhiteSpace(data.Name)) return BadRequest("Invalid input :" + nameof(data.Name));
            if (string.IsNullOrWhiteSpace(data.Occupation)) return BadRequest("Invalid input :" + nameof(data.Occupation));

            int cacheExpiryDays = Convert.ToInt32(_configuration["InMemoryCacheDays"]);
            string fileName = _configuration["AdHtmlTemplateFileName"];
            string bucketName = _configuration["AdBucketNameInGoogleCloudStorage"];
            Guid objectName = Guid.NewGuid();

            var anonymousDataObject = data.ConvertToAnonymousType(data);
            _adService.UploadObjectInGoogleCloudStorage(fileName, cacheExpiryDays, objectName, bucketName, anonymousDataObject);

            return Ok(new { Name = "Chinna", Email = "chinnarao@live.com" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok( new { Name = "Chinna", Email = "chinnarao@live.com" });
        }
    }
}