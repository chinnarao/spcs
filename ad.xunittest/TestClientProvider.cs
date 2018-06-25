using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;

//https://www.youtube.com/watch?v=p5l7x_pFjmI
namespace ad.xunittest
{
    public class TestClientProvider : IDisposable
    {
        private TestServer _TestServer;
        public HttpClient HttpClient { get; private set; }

        public TestClientProvider()
        {
            try
            {
                _TestServer = new TestServer(new WebHostBuilder().UseStartup<ad.Startup>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            HttpClient = _TestServer.CreateClient();
        }

        public void Dispose()
        {
            _TestServer?.Dispose();
            HttpClient.Dispose();
        }
    }
}
