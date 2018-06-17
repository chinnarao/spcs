using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SP.DL.Services;
using common;
using common.enums;

namespace SP.Territories.Controllers
{
    //[ResponseCache(VaryByQueryKeys = new string[] { "test" }, Duration = 30)]
    //[ResponseCache(Duration = 20)]
    //[Produces("application/json")]
    [Route("api/[controller]")]
    public class TerritoriesController : Microsoft.AspNetCore.Mvc.Controller
    {
        //private readonly IDistributedCache _cache;
        //readonly ILogger<TerritoriesController> _log;
        //IRavenClient _RavenClient;
        ITerritoriesService _TerritoriesService;
        //AppSettings _AppSettings;
        public TerritoriesController(ITerritoriesService territoriesService) //ITerritoriesService territoriesService
        {
            //_log = log;
            //_RavenClient = ravenClient;
            _TerritoriesService = territoriesService;
            //_AppSettings = appSettings;
            //_cache = cache;
        }

        //Countries:        http://localhost:5000/api/Territories/Get/1
        //States:           http://localhost:51284/api/Territories/Get/2?cc=IN
        //CountyOrProvinces:http://localhost:51284/api/Territories/Get/3?cc=IN&code=02&name=Andhra%20Pradesh
        //Communities:      http://localhost:51284/api/Territories/Get/4?cc=IN&code=543&name=Vizianagaram
        //Places:           http://localhost:51284/api/Territories/Get/5?cc=IN&code=&name=Bobbili
        //[HttpGet("{i}", Name = "Get")]
        [Route("[action]/{i:int}")]
        public IActionResult Get(int i, string cc, string code, string name)
        {
            throw new System.Exception("this is chinna for serilog error testing....................................");
            if (i > 1 && (string.IsNullOrWhiteSpace(cc) || cc.Length > 2))
                return BadRequest();
            switch ((TerritoryTypeEnum)i)
            {
                case TerritoryTypeEnum.Country:
                    return Ok(_TerritoriesService.GetCountries());
                case TerritoryTypeEnum.State:
                    return Ok(_TerritoriesService.GetStates(cc));
                case TerritoryTypeEnum.CountyOrProvince:
                    return Ok(_TerritoriesService.GetCountyOrProvinces(cc, code, name));
                case TerritoryTypeEnum.Community:
                    return Ok(_TerritoriesService.GetCommunities(cc, code, name));
                case TerritoryTypeEnum.Place:
                    return Ok(_TerritoriesService.GetPlaceNames(cc, code, name));
                default:
                    return NotFound();
            }
        }
    }
}