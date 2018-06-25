using FluentAssertions;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ad.xunittest
{
    public class ConfigurationTest
    {
        [Fact]
        public void Test_Configuration()
        {
            IConfiguration _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            int days = Convert.ToInt32(_configuration["InMemoryCacheDays"]);
            string fileName = _configuration["AdHtmlTemplateFileName"];
            Action act1 = () => days.Should().BePositive();
            act1.Should().NotThrow();
            Action act2 = () => fileName.Should().EndWith(".html");
            act2.Should().NotThrow();
        }
    }
}
