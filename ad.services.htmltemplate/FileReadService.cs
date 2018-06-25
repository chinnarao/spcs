using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using common.constants;
using Microsoft.Extensions.Configuration;

namespace ad.services.htmltemplate
{
    public class FileReadService : IFileReadService
    {
        private readonly IConfiguration _config;
        private readonly IMemoryCache _memoryCache;
        public FileReadService(IConfiguration configuration, IMemoryCache memoryCache)
        {
            _config = configuration;
            _memoryCache = memoryCache;
        }

        public string FileAsString(string path)
        {
            string _htmlFileContent = string.Empty;
            if (!_memoryCache.TryGetValue(Constants.AD_HTML_FILE_TEMPLATE, out _htmlFileContent))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    _htmlFileContent = sr.ReadToEnd();
                }
                var opts = new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromDays(Convert.ToInt32(_config["InMemoryCacheDays"]))
                };
                _memoryCache.Set(Constants.AD_HTML_FILE_TEMPLATE, _htmlFileContent, opts);
            }

            if (string.IsNullOrEmpty(_htmlFileContent))
                throw new Exception("Ad Html File Template content is empty, unexpected.");

            return _htmlFileContent;
        }
    }

    public interface IFileReadService
    {
        string FileAsString(string path);
    }
}
