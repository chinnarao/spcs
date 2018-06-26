using ad.xunittest.Infrastructure;
using FluentAssertions;
using System;
using System.Globalization;
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

        [Fact]
        public void Test_PostAd1()
        {
            for (int i = 0; i < 2; i++)
            {

                Guid g = Guid.NewGuid();
                string sfsf = g.ToString();
                string g1 = g.ToString("N");
                Guid sfs = new Guid(g1);

                string a1 = DateTime.Now.Ticks.ToString();
                string a2 = DateTime.Now.Ticks.ToString();
                string a3 = DateTime.Now.Ticks.ToString();
                string a4 = DateTime.Now.Ticks.ToString();
                string a5 = DateTime.Now.Ticks.ToString();
                string a6 = DateTime.Now.Ticks.ToString();
                string a7 = DateTime.Now.Ticks.ToString();

                string a = a1.ToString() + " " + a2.ToString() + " " + a3.ToString() + " " + a4.ToString() + " " + a5.ToString() + " " + a6.ToString() + " " + a7.ToString();

                //A single tick represents one hundred nanoseconds or one ten-millionth of a second. 
                //There are 10,000 ticks in a millisecond, or 10 million ticks in a second.
                DateTime local = DateTime.Now;
                string s = local.ToString("yyyy-MM-dd hh.mm.ss.ffffff");
                DateTime utc = DateTime.UtcNow;
                Int64 tickslocal = DateTime.Now.Ticks;
                Int64 ticksUtc = DateTime.UtcNow.Ticks;
                DateTime tickdTlocal = new DateTime(tickslocal);
                DateTime tickdTutc = new DateTime(ticksUtc);
                string timestamp = utc.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
                string timestamp1 = utc.ToString("yyyy-MM-dd HH:mm:ss.fffff",CultureInfo.InvariantCulture);

                Int32 milliseconds = DateTime.Now.Millisecond;
            }
            
            Assert.True(1 < 2);
        }
    }
}
