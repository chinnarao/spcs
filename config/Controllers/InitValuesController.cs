using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.FileProviders;
using config.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using config.Models;
using System;
using Microsoft.Extensions.Caching.Memory;
using config.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

#region articles
//https://azure.microsoft.com/en-us/pricing/details/key-vault/
//https://cryptosense.com/blog/cloud-crypto-providers-aws-vs-google-vs-azure/
//https://ourcodeworld.com/articles/read/189/how-to-create-a-file-and-generate-a-download-with-javascript-in-the-browser-without-a-server
//https://github.com/ntn9995/CacheASPCore20/blob/master/WebCache/Controllers/HomeController.cs
//[ResponseCache(Duration =60 , Location = ResponseCacheLocation.None)]
#endregion

namespace config.Controllers
{
    //header('Content-type: application/json');
    //[Produces("application/json")]
    //[Route("api/InitValues")]
    //https://github.com/madskristensen/WebEssentials.AspNetCore.StaticFilesWithCache
    public class InitValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<InitValuesController> _logger;
        private readonly IFileProvider _fileProvider;
        private readonly IHostingEnvironment _hostingEnvironment;
        private IMemoryCache _memoryCache;
        private readonly IReadService _readService;
        private const string _countriesFileName = "countries.json";
        private string _countriesJsonFilePath = string.Empty;
        public InitValuesController(IConfiguration configuration, ILogger<InitValuesController> logger, IHostingEnvironment hostingEnvironment, IMemoryCache memoryCache, IFileProvider fileProvider, IReadService readService)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
            _memoryCache = memoryCache;
            _fileProvider = fileProvider;
            _readService = readService;
            _countriesJsonFilePath = Path.Combine(_hostingEnvironment.ContentRootPath, "Files", "countries.json");
        }

        [HttpGet]
        public IActionResult Get()
        {
            ClientAppStartupVM vm = new ClientAppStartupVM();
            vm.SignUpUrl = "https://localhost:44396/account/signup";
            vm.LoginUrl = "https://localhost:44396/account/login";
            vm.AppBaseUrl = "https://localhost:44396";
            vm.Facebook = "Facebook fsdfsfsfsfsfs3543535353";
            vm.Google = "Google";
            vm.LinkedIn = "LinkedIn";
            vm.Microsoft = "Microsoft";
            return Ok(vm);
        }

        [HttpGet]
        public IActionResult GetCountryNames(string TerritoryCode)
        {
            Dictionary<string, string> CountryNamesDictionary = new Dictionary<string, string>
            {
                {"AD", "Andorra"},{"AR", "Argentina"},{"AS", "AmericanSamoa"},{"AT", "Austria"},{"AU", "Australia"},{"AX", "�landIslands"},{"BD", "Bangladesh"},{"BE", "Belgium"},{"BG", "Bulgaria"},{"BR", "Brazil"},{"BY", "Belarus"},{"CA", "Canada"},{"CH", "Switzerland"},{"CO", "Colombia"},{"CR", "CostaRica"},{"CZ", "Czechia"},{"DE", "Germany"},{"DK", "Denmark"},{"DO", "DominicanRepublic"},{"DZ", "Algeria"},{"ES", "Spain"},{"FI", "Finland"},{"FO", "FaroeIslands"},{"FR", "France"},{"GB", "UnitedKingdom"},{"GF", "FrenchGuiana"},{"GG", "Guernsey"},{"GL", "Greenland"},{"GP", "Guadeloupe"},{"GT", "Guatemala"},{"GU", "Guam"},{"HR", "Croatia"},{"HU", "Hungary"},{"IE", "Ireland"},{"IM", "IsleofMan"},{"IN", "India"},{"IS", "Iceland"},{"IT", "Italy"},{"JE", "Jersey"},{"JP", "Japan"},{"LI", "Liechtenstein"},{"LK", "SriLanka"},{"LT", "Lithuania"},{"LU", "Luxembourg"},{"MC", "Monaco"},{"MD", "Moldova"},{"MH", "MarshallIslands"},{"MK", "Macedonia"},{"MP", "NorthernMarianaIslands"},{"MQ", "Martinique"},{"MT", "Malta"},{"MX", "Mexico"},{"MY", "Malaysia"},{"NC", "NewCaledonia"},{"NL", "Netherlands"},{"NO", "Norway"},{"NZ", "NewZealand"},{"PH", "Philippines"},{"PK", "Pakistan"},{"PL", "Poland"},{"PM", "St.Pierre&Miquelon"},{"PR", "PuertoRico"},{"PT", "Portugal"},{"RE", "R�union"},{"RO", "Romania"},{"RU", "Russia"},{"SE", "Sweden"},{"SI", "Slovenia"},{"SJ", "Svalbard&JanMayen"},{"SK", "Slovakia"},{"SM", "SanMarino"},{"TH", "Thailand"},{"TR", "Turkey"},{"US", "UnitedStates"},{"VA", "VaticanCity"},{"VI", "U.S.VirginIslands"},{"WF", "Wallis&Futuna"},{"YT", "Mayotte"},{"ZA", "SouthAfrica"}
            };
            string result;
            if (CountryNamesDictionary.TryGetValue(TerritoryCode, out result))
                return Ok(result);
            return NotFound();
        }

        [Route("countries")]
        public IActionResult DownloadPhysicalCountriesJsonFile()
        {
            return PhysicalFile(_countriesJsonFilePath, "application/json", "countries.json");
        }

        [Route("countriesdata")]
        public IActionResult GetCountriesJsonDataString()
        {
            string CountryCodesAndNames = string.Empty;
            if (!_memoryCache.TryGetValue(Constants.COUNTRIES, out CountryCodesAndNames))
            {
                CountryCodesAndNames = _readService.GetJsonDataFromFile(_countriesFileName);
                var opts = new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromDays(Convert.ToInt32(_configuration["InMemoryCacheDays"]))
                };
                _memoryCache.Set(Constants.COUNTRIES, CountryCodesAndNames, opts);
            }

            if (string.IsNullOrEmpty(CountryCodesAndNames))
                return NotFound();
            return Ok(CountryCodesAndNames);
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.GetFilename());

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return RedirectToAction("Files");
        }

        [HttpPost]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
                return Content("files not selected");

            foreach (var file in files)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.GetFilename());
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return RedirectToAction("Files");
        }

        public IActionResult Files()
        {
            Dictionary<string, string> dictFiles = new Dictionary<string, string>();
            List<Dictionary<string, string>> FileDicts = new List<Dictionary<string, string>>();
            foreach (var item in this._fileProvider.GetDirectoryContents(""))
            {
                FileDicts.Add(new Dictionary<string, string> { { "filename.txt", "my name is chinna!" } });
            }
            return Ok(FileDicts);
        }
    }
}