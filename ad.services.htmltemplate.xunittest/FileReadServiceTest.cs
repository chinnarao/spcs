using Microsoft.Extensions.Caching.Memory;
using System;
using Xunit;
using FluentAssertions;
using System.IO;

namespace ad.services.htmltemplate.xunittest
{
    public class FileReadServiceTest
    {
        [Fact]
        public void Test_FileAsString()
        {
            int days = Helper.GetCacheExpireDays();
            string fileName = Helper.GetAdFileName();
            IMemoryCache _memoryCache = Helper.GetDefaultMemoryCacheObject();
            string firstTimeContent = new FileReadService(_memoryCache).FileAsString(fileName, days);
            Action act = () => firstTimeContent.Should().NotBeEmpty();
            act.Should().NotThrow();
            string secondTimeContent = new FileReadService(_memoryCache).FileAsString(fileName, days);
            act = () => secondTimeContent.Should().BeSameAs(firstTimeContent);
            act.Should().NotThrow();
        }

        [Fact]
        public void Test_FillContent()
        {
            var anonymousData = new
            {
                Name = "Riya",
                Occupation = "Kavin Brother."
            };

            string content = new FileReadService(Helper.GetDefaultMemoryCacheObject()).FillContent(Helper.GetAdTemplateFileContent(), anonymousData);
            Action act = () => content.Should().Contain(anonymousData.Name);
            act.Should().NotThrow();
            Action act1 = () => content.Should().Contain(anonymousData.Occupation);
            act1.Should().NotThrow();
        }

        [Fact]
        public void Test_FileAsStream()
        {
            var anonymousData = new
            {
                Name = "Riya",
                Occupation = "Kavin Brother."
            };
            string content = new FileReadService(Helper.GetDefaultMemoryCacheObject()).FillContent(Helper.GetAdTemplateFileContent(), anonymousData);
            Stream stream = new FileReadService(Helper.GetDefaultMemoryCacheObject()).FileAsStream(content);
            Action act = () => stream.Should().NotBeNull();
            act.Should().NotThrow();
        }
    }
}