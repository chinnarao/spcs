using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

//https://www.youtube.com/watch?v=p5l7x_pFjmI
//https://www.meziantou.net/2017/08/21/testing-an-asp-net-core-application-using-testserver
namespace ad.xunittest.Infrastructure
{
    public class TestClientProvider : IDisposable
    {
        private TestServer _server;
        public HttpClient HttpClient { get; private set; }

        public TestClientProvider()
        {
            var webHostBuilder = new WebHostBuilder()
                    .ConfigureAppConfiguration(
                        (builderContext, config) => { config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);}
                    )
                    .UseStartup<ad.Startup>();

            _server = new TestServer(webHostBuilder);
            HttpClient = _server.CreateClient();
        }

        public void Dispose()
        {
            HttpClient.Dispose();
        }
    }
}
