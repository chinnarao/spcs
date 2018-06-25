using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ad.services.htmltemplate.xunittest
{
    public class Helper
    {
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            return config;
        }

        public static IMemoryCache GetDefaultMemoryCacheObject()
        {
            IConfiguration _config = Helper.InitConfiguration();
            int days = Convert.ToInt32(_config["InMemoryCacheDays"]);
            var opts = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(days)
            };
            IMemoryCache _memoryCache = new MemoryCache(new MemoryCacheOptions());
            return _memoryCache;
        }

        public static string GetAdFileName()
        {
            IConfiguration _config = Helper.InitConfiguration();
            string fileName = _config["AdHtmlTemplateFileName"];
            return fileName;
        }

        public static int GetCacheExpireDays()
        {
            IConfiguration _config = Helper.InitConfiguration();
            int days = Convert.ToInt32(_config["InMemoryCacheDays"]);
            return days;
        }

        public static string GetAdTemplateFileContent()
        {
            int days = Helper.GetCacheExpireDays();
            string fileName = Helper.GetAdFileName();
            IMemoryCache _memoryCache = Helper.GetDefaultMemoryCacheObject();
            string content = new FileReadService(_memoryCache).FileAsString(fileName, days);
            return content;
        }
    }
}
