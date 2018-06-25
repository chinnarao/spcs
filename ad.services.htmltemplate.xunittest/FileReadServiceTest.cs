using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using Xunit;
using FluentAssertions;

namespace ad.services.htmltemplate.xunittest
{
    public class FileReadServiceTest
    {
        [Fact]
        public void Test_FileAsString()
        {
            IConfiguration _config = Helper.InitConfiguration();
            int days = Convert.ToInt32(_config["InMemoryCacheDays"]);
            string fileName = _config["AdHtmlTemplateFileName"];
            //AdHtmlTemplateFileName
            var opts = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(days)
            };
            IMemoryCache _memoryCache = new MemoryCache(new MemoryCacheOptions());
            string firstTimeContent = new FileReadService(_memoryCache).FileAsString(fileName, days);
            Action act = () => firstTimeContent.Should().NotBeEmpty();
            act.Should().NotThrow();
            string secondTimeContent = new FileReadService(_memoryCache).FileAsString(fileName, days);
            act = () => secondTimeContent.Should().BeSameAs(firstTimeContent);
            act.Should().NotThrow();
        }
    }
}
