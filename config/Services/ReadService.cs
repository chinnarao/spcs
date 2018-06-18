using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace config.Services
{
    public class ReadService : IReadService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<ReadService> _logger;
        private readonly IFileProvider _fileProvider;
        private readonly IHostingEnvironment _hostingEnvironment;
        private IMemoryCache _memoryCache;

        public ReadService(IConfiguration configuration, ILogger<ReadService> logger, IHostingEnvironment hostingEnvironment, IMemoryCache memoryCache, IFileProvider fileProvider)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
            _memoryCache = memoryCache;
            _fileProvider = fileProvider;
        }

        public string GetJsonDataFromFile(string path)
        {
            IFileInfo file = this._fileProvider.GetFileInfo(path);
            if (file.Exists)
            {
                using (var stream = file.CreateReadStream())
                using (var reader = new StreamReader(stream))
                {
                    var output = reader.ReadToEnd();
                    return output.ToString();
                }
            }
            return string.Empty;
        }
    }

    public interface IReadService
    {
        string GetJsonDataFromFile(string path);
    }
}
