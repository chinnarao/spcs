using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ad.xunittest
{
    public class AdControllerTest
    {
        [Fact]
        public async Task Test_GetAll()
        {
            using (var httpClient = new TestClientProvider().HttpClient)
            {
                var response = await httpClient.GetAsync("/api/Values");
                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK);
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
