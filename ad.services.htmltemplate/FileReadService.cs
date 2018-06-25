using Microsoft.Extensions.Caching.Memory;
using System;
using System.IO;
using common.constants;

namespace ad.services.htmltemplate
{
    public class FileReadService : IFileReadService
    {
        private readonly IMemoryCache _memoryCache;
        public FileReadService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        /// <summary>
        /// file shoud be build to copy always in file properties
        /// </summary>
        /// <param name="fileName">ad.template.html</param>
        /// <param name="inMemoryCachyExpireDays"></param>
        /// <returns></returns>
        public string FileAsString(string fileName, int inMemoryCachyExpireDays)
        {
            if (inMemoryCachyExpireDays <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(inMemoryCachyExpireDays));
            }
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentOutOfRangeException(nameof(fileName));
            }
            string _htmlFileContent = string.Empty;
            if (!_memoryCache.TryGetValue(Constants.AD_HTML_FILE_TEMPLATE, out _htmlFileContent))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    _htmlFileContent = sr.ReadToEnd();
                }
                var opts = new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromDays(inMemoryCachyExpireDays)
                };
                _memoryCache.Set(Constants.AD_HTML_FILE_TEMPLATE, _htmlFileContent, opts);
            }

            if (string.IsNullOrEmpty(_htmlFileContent))
                throw new Exception("Ad Html File Template content is empty, unexpected.");

            return _htmlFileContent;
        }

        public string FillContent(string content, object anonymousDataObject)
        {
            var template = Scriban.Template.Parse(content);
            if (template.HasErrors)
            {
                throw new Exception(string.Join<Scriban.Parsing.LogMessage>(',', template.Messages.ToArray()));
            }
            string result = template.Render(anonymousDataObject);
            return result;
        }
    }

    public interface IFileReadService
    {
        string FileAsString(string fileName, int inMemoryCachyExpireDays);
        string FillContent(string content, object anonymousDataObject);
    }
}
