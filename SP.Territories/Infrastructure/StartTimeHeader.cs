using Microsoft.AspNetCore.Http;
using common;
using SP.DL.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;

//http://blog.getseq.net/smart-logging-middleware-for-asp-net-core/
//https://docs.microsoft.com/en-us/aspnet/core/performance/caching/distributed
namespace SP.Territories
{
    public class StartTimeHeader
    {
        private readonly RequestDelegate _next;
        private readonly IDistributedCache _cache;

        public StartTimeHeader(RequestDelegate next,
           IDistributedCache cache)
        {
            _next = next;
            _cache = cache;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string startTimeString = "Not found.";
            var value = await _cache.GetAsync("lastServerStartTime");
            if (value != null)
            {
                startTimeString = Encoding.UTF8.GetString(value);
            }

            httpContext.Response.Headers.Append("Last-Server-Start-Time", startTimeString);

            await _next.Invoke(httpContext);
        }
    }

}