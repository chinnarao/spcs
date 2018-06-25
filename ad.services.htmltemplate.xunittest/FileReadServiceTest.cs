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
        public void Test_Configuration()
        {
            IConfiguration _config = Helper.InitConfiguration();
            int days = Convert.ToInt32(_config["InMemoryCacheDays"]);
            Action act = () => days.Should().BePositive();
            act.Should().NotThrow();
        }

        [Fact]
        public void Test_FileAsString()
        {
            string fileName = "ad.template.html";
            IConfiguration _config = Helper.InitConfiguration();
            int days = Convert.ToInt32(_config["InMemoryCacheDays"]);
            var opts = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(days)
            };
            IMemoryCache _memoryCache = new MemoryCache(new MemoryCacheOptions());
            string firstTimeContent = new FileReadService(_config, _memoryCache).FileAsString(fileName);
            Action act = () => firstTimeContent.Should().NotBeEmpty();
            act.Should().NotThrow();
            string secondTimeContent = new FileReadService(_config, _memoryCache).FileAsString(fileName);
            act = () => secondTimeContent.Should().BeSameAs(firstTimeContent);
            act.Should().NotThrow();
        }
    }
}
