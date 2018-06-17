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

#region articles
//https://azure.microsoft.com/en-us/pricing/details/key-vault/
//https://cryptosense.com/blog/cloud-crypto-providers-aws-vs-google-vs-azure/
//https://ourcodeworld.com/articles/read/189/how-to-create-a-file-and-generate-a-download-with-javascript-in-the-browser-without-a-server
#endregion

namespace config.Controllers
{
    //header('Content-type: application/json');
    //[Produces("application/json")]
    //[Route("api/InitValues")]
    public class InitValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<InitValuesController> _logger;
        private readonly IFileProvider _fileProvider;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly string _path;

        public InitValuesController(IConfiguration configuration, ILogger<InitValuesController> logger, IHostingEnvironment hostingEnvironment, IFileProvider fileProvider)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
            _fileProvider = fileProvider;
            _path = Path.Combine(_hostingEnvironment.ContentRootPath, @"files\countries.json");
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
        public IActionResult GetCountryCodeAndName(string TerritoryCode)
        {
            Dictionary<string, string> CountryCodesAndNamesDictionary = new Dictionary<string, string>
            {
                {"AD", "AD_Andorra"},{"AR", "AR_Argentina"},{"AS", "AS_AmericanSamoa"},{"AT", "AT_Austria"},{"AU", "AU_Australia"},{"AX", "AX_landIslands"},{"BD", "BD_Bangladesh"},{"BE", "BE_Belgium"},{"BG", "BG_Bulgaria"},{"BR", "BR_Brazil"},{"BY", "BY_Belarus"},{"CA", "CA_Canada"},{"CH", "CH_Switzerland"},{"CO", "CO_Colombia"},{"CR", "CR_CostaRica"},{"CZ", "CZ_Czechia"},{"DE", "DE_Germany"},{"DK", "DK_Denmark"},{"DO", "DO_DominicanRepublic"},{"DZ", "DZ_Algeria"},{"ES", "ES_Spain"},{"FI", "FI_Finland"},{"FO", "FO_FaroeIslands"},{"FR", "FR_France"},{"GB", "GB_UnitedKingdom"},{"GF", "GF_FrenchGuiana"},{"GG", "GG_Guernsey"},{"GL", "GL_Greenland"},{"GP", "GP_Guadeloupe"},{"GT", "GT_Guatemala"},{"GU", "GU_Guam"},{"HR", "HR_Croatia"},{"HU", "HU_Hungary"},{"IE", "IE_Ireland"},{"IM", "IM_IsleofMan"},{"IN", "IN_India"},{"IS", "IS_Iceland"},{"IT", "IT_Italy"},{"JE", "JE_Jersey"},{"JP", "JP_Japan"},{"LI", "LI_Liechtenstein"},{"LK", "LK_SriLanka"},{"LT", "LT_Lithuania"},{"LU", "LU_Luxembourg"},{"MC", "MC_Monaco"},{"MD", "MD_Moldova"},{"MH", "MH_MarshallIslands"},{"MK", "MK_Macedonia"},{"MP", "MP_NorthernMarianaIslands"},{"MQ", "MQ_Martinique"},{"MT", "MT_Malta"},{"MX", "MX_Mexico"},{"MY", "MY_Malaysia"},{"NC", "NC_NewCaledonia"},{"NL", "NL_Netherlands"},{"NO", "NO_Norway"},{"NZ", "NZ_NewZealand"},{"PH", "PH_Philippines"},{"PK", "PK_Pakistan"},{"PL", "PL_Poland"},{"PM", "PM_St.Pierre&Miquelon"},{"PR", "PR_PuertoRico"},{"PT", "PT_Portugal"},{"RE", "RE_R�union"},{"RO", "RO_Romania"},{"RU", "RU_Russia"},{"SE", "SE_Sweden"},{"SI", "SI_Slovenia"},{"SJ", "SJ_Svalbard&JanMayen"},{"SK", "SK_Slovakia"},{"SM", "SM_SanMarino"},{"TH", "TH_Thailand"},{"TR", "TR_Turkey"},{"US", "US_UnitedStates"},{"VA", "VA_VaticanCity"},{"VI", "VI_U.S.VirginIslands"},{"WF", "WF_Wallis&Futuna"},{"YT", "YT_Mayotte"},{"ZA", "ZA_SouthAfrica"}
            };
            string result;
            if (CountryCodesAndNamesDictionary.TryGetValue(TerritoryCode, out result))
                return Ok(result);
            return NotFound();
        }

        [HttpGet]
        public IActionResult GetCountryName(string TerritoryCode)
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

        [Route("normal")]
        public IActionResult DownloadNormal()
        {
            _logger.LogWarning("Normal ---> download started at {} \n ", DateTime.Now.TimeOfDay);

            var fileInfo = new FileInfo(_path);
            string a = Path.Combine(_hostingEnvironment.ContentRootPath, @"files\countries.json");
            return PhysicalFile(a, "application/json", "abc.json");
        }

        //[HttpPost]
        //public async Task<IActionResult> UploadFile(IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //        return Content("file not selected");

        //    var path = Path.Combine(
        //                Directory.GetCurrentDirectory(), "wwwroot",
        //                file.GetFilename());

        //    using (var stream = new FileStream(path, FileMode.Create))
        //    {
        //        await file.CopyToAsync(stream);
        //    }

        //    return RedirectToAction("Files");
        //}
        //[HttpPost]
        //public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        //{
        //    if (files == null || files.Count == 0)
        //        return Content("files not selected");

        //    foreach (var file in files)
        //    {
        //        var path = Path.Combine(
        //                Directory.GetCurrentDirectory(), "wwwroot",
        //                file.GetFilename());

        //        using (var stream = new FileStream(path, FileMode.Create))
        //        {
        //            await file.CopyToAsync(stream);
        //        }
        //    }

        //    return RedirectToAction("Files");
        //}
        //[HttpPost]
        //public async Task<IActionResult> UploadFileViaModel(IFormFile FileToUpload)
        //{
        //    if (FileToUpload == null || FileToUpload.Length == 0)
        //        return Content("file not selected");

        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", FileToUpload.GetFilename());

        //    using (var stream = new FileStream(path, FileMode.Create))
        //    {
        //        await FileToUpload.CopyToAsync(stream);
        //    }

        //    return RedirectToAction("Files");
        //}
        //public IActionResult Files()
        //{
        //    Dictionary<string, string> dictFiles = new Dictionary<string, string>();
        //    //List<FileDetails> Files  = new List<FileDetails>(); // this line is copied from worked code , replaced by me with dictionary
        //    List<Dictionary<string, string>> FileDicts = new List<Dictionary<string, string>>();
        //    foreach (var item in this._fileProvider.GetDirectoryContents(""))
        //    {
        //        //Files.Add(new FileDetails { Name = item.Name, Path = item.PhysicalPath });
        //        FileDicts.Add( new Dictionary<string, string>{ {"filename.txt", "my name is chinna!"} } );
        //    }
        //    return View(FileDicts);
        //}
        //public async Task<IActionResult> Download(string filename)
        //{
        //    if (filename == null)
        //        return Content("filename not present");

        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", filename);

        //    var memory = new MemoryStream();
        //    using (var stream = new FileStream(path, FileMode.Open))
        //    {
        //        await stream.CopyToAsync(memory);
        //    }
        //    memory.Position = 0;
        //    return File(memory, "application/json", Path.GetFileName(path));
        //}
        //public async Task<IActionResult> GetCountryJsonFile()
        //{
        //    string filename = _configuration.GetConnectionString("coutriesjsonfilename");// "countries.json";
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", filename);
        //    if (!System.IO.File.Exists(filename))
        //    {
        //        return Content("");
        //    }
        //    var memory = new MemoryStream();
        //    using (var stream = new FileStream(path, FileMode.Open))
        //    {
        //        await stream.CopyToAsync(memory);
        //    }
        //    memory.Position = 0;
        //    return File(memory, "application/json", Path.GetFileName(path));
        //}
    }
}