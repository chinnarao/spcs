using System;
using System.Collections.Generic;
using System.Linq;
using SP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using SP.StaticData;
using System.Reflection;
using common.constants;

namespace SP.DL.Services
{
    public class TerritoriesService : ITerritoriesService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TerritoriesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Dictionary<string, string> GetCountries()
        {
            return CountryStatic.CountryNamesDictionary;
        }

        //sql query : "select distinct statecode,statename from IN_India order by statename"  IN_States
        public IEnumerable<KeyValuePair<string, string>> GetGenericStates<TEntity>() where TEntity : GeoNameTxt, new()
        {
            return _unitOfWork.GetRepository<TEntity>()
                .SelectAsKeyValuePair(t => new KeyValuePair<string, string>(t.statecode, t.statename))
                .Distinct().OrderBy(a => a.Value);
        }

        public IEnumerable<KeyValuePair<string, string>> GetGenericCountyOrProvinces<TEntity>(string statecode, string statename) where TEntity : GeoNameTxt
        {
            //return _unitOfWork.GetRepository<TEntity>()
            //    .Query( s => s.statecode.Equals(statecode) && s.statename.Equals(statename))
            //    .Select(t => new KeyValuePair<string, string>(t.countyorprovincecode, t.countyorprovincename))
            //    .Distinct().OrderBy(a => a.Value);

            return _unitOfWork.GetRepository<TEntity>()
                .GetPagedList(s => s.statecode.Equals(statecode) && s.statename.Equals(statename))
                .Items.Select(t => new KeyValuePair<string, string>(t.countyorprovincecode, t.countyorprovincename))
                .Distinct().OrderBy(a => a.Value);
        }

        public IEnumerable<KeyValuePair<string, string>> GetGenericCommunities<TEntity>(string countyorprovincecode, string countyorprovincename) where TEntity : GeoNameTxt
        {
            //return _unitOfWork.GetRepository<TEntity>()
            //    .Query(s => s.countyorprovincecode.Equals(countyorprovincecode) && s.countyorprovincename.Equals(countyorprovincename))
            //    .Select(t => new KeyValuePair<string, string>(t.communitycode, t.communityname))
            //    .Distinct().OrderBy(a => a.Value);

            return _unitOfWork.GetRepository<TEntity>()
                .GetPagedList(s => s.countyorprovincecode.Equals(countyorprovincecode) && s.countyorprovincename.Equals(countyorprovincename))
                .Items.Select(t => new KeyValuePair<string, string>(t.communitycode, t.communityname))
                .Distinct().OrderBy(a => a.Value);
        }

        public IEnumerable<KeyValuePair<string, string>> GetGenericPlaceNames<TEntity>(string communitycode, string communityname) where TEntity : GeoNameTxt
        {
            //return _unitOfWork.GetRepository<TEntity>()
            //    .Query(s => s.communitycode.Equals(communitycode) && s.communityname.Equals(communityname))
            //    .Select(t => new KeyValuePair<string, string>(t.postalcode, t.placename))
            //    .Distinct().OrderBy(a => a.Value);

            return _unitOfWork.GetRepository<TEntity>()
                .GetPagedList(s => s.communitycode.Equals(communitycode) && s.communityname.Equals(communityname))
                .Items.Select(t => new KeyValuePair<string, string>(t.postalcode, t.placename))
                .Distinct().OrderBy(a => a.Value);
        }

        public object GetStates(string countryCode)
        {
            string TerritoryName = CountryStatic.GetCountryCodeAndName(countryCode);
            Type territoryType = Type.GetType(string.Format(Constants.SP_DAL_QUALIFIEDNAME, TerritoryName));
            MethodInfo mi = typeof(TerritoriesService).GetMethod("GetGenericStates").MakeGenericMethod(territoryType);
            var states = mi.Invoke(this, null);
            return states;
        }
        public object GetCountyOrProvinces(string countryCode, string statecode, string statename)
        {
            string TerritoryName = CountryStatic.GetCountryCodeAndName(countryCode);
            Type territoryType = Type.GetType(string.Format(Constants.SP_DAL_QUALIFIEDNAME, TerritoryName));
            MethodInfo mi = typeof(TerritoriesService).GetMethod("GetGenericCountyOrProvinces").MakeGenericMethod(territoryType);
            var CountyOrProvinces = mi.Invoke(this, new string[] { statecode ?? "", statename });
            return CountyOrProvinces;
        }

        public object GetCommunities(string countryCode, string countyorprovincecode, string countyorprovincename)
        {
            string TerritoryName = CountryStatic.GetCountryCodeAndName(countryCode);
            Type territoryType = Type.GetType(string.Format(Constants.SP_DAL_QUALIFIEDNAME, TerritoryName));
            MethodInfo mi = typeof(TerritoriesService).GetMethod("GetGenericCommunities").MakeGenericMethod(territoryType);
            var Communities = mi.Invoke(this, new string[] { countyorprovincecode ?? "", countyorprovincename });
            return Communities;
        }

        public object GetPlaceNames(string countryCode, string communitycode, string communityname)
        {
            string TerritoryName = CountryStatic.GetCountryCodeAndName(countryCode);
            Type territoryType = Type.GetType(string.Format(Constants.SP_DAL_QUALIFIEDNAME, TerritoryName));
            MethodInfo mi = typeof(TerritoriesService).GetMethod("GetGenericPlaceNames").MakeGenericMethod(territoryType);
            var PlaceNames = mi.Invoke(this, new string[] { communitycode ?? "", communityname });
            return PlaceNames;
        }
    }

    public interface ITerritoriesService
    {
        Dictionary<string, string> GetCountries();
        IEnumerable<KeyValuePair<string, string>> GetGenericStates<TEntity>() where TEntity : GeoNameTxt, new();
        IEnumerable<KeyValuePair<string, string>> GetGenericCountyOrProvinces<TEntity>(string statecode, string statename) where TEntity : GeoNameTxt;
        IEnumerable<KeyValuePair<string, string>> GetGenericCommunities<TEntity>(string countyorprovincecode, string countyorprovincename) where TEntity : GeoNameTxt;
        IEnumerable<KeyValuePair<string, string>> GetGenericPlaceNames<TEntity>(string communitycode, string communityname) where TEntity : GeoNameTxt;
        object GetStates(string countryCode);
        object GetCountyOrProvinces(string countryCode, string statecode, string statename);
        object GetCommunities(string countryCode, string countyorprovincecode, string countyorprovincename);
        object GetPlaceNames(string countryCode, string communitycode, string communityname);
    }
}
