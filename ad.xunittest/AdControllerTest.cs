using ad.xunittest.Infrastructure;
using FluentAssertions;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ad.xunittest
{
    public class AdControllerTest
    {
        [Fact]
        public async Task Test_PostAd()
        {
            using (var httpClient = new TestClientProvider().HttpClient)
            {
                HttpResponseMessage response = await httpClient.GetAsync("/Ad/PostAd");
                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK); // or old school: Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
