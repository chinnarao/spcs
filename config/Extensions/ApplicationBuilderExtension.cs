using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

//https://github.com/madskristensen/WebEssentials.AspNetCore.StaticFilesWithCache
namespace config.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseStaticFilesWithCache(this IApplicationBuilder app, IConfiguration Configuration, ILogger logger)
        {
            try
            {
                bool isStaticFileCacheRqd = Convert.ToBoolean(Configuration["IsStaticFilesWithCache"]);
                int staticCacheDays = Convert.ToInt32(Configuration["ClientSideStaticFileCacheDays"]);
                TimeSpan cacheExpiration = TimeSpan.FromDays(staticCacheDays);
                if (isStaticFileCacheRqd)
                {
                    app.UseStaticFiles(new StaticFileOptions()
                    {
                        OnPrepareResponse = (context) =>
                        {
                            context.Context.Response.Headers[HeaderNames.CacheControl] = $"max-age={cacheExpiration.TotalSeconds.ToString()}";
                            context.Context.Response.Headers[HeaderNames.Expires] = DateTime.UtcNow.Add(cacheExpiration).ToString("R");

                            if (context.Context.Request.Query.ContainsKey("v"))
                            {
                                context.Context.Response.Headers[HeaderNames.CacheControl] += ",immutable";
                            }
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                logger.LogCritical("Did not cache data, Method: UseStaticFile" + ex.ToString());
            }
            return app;
        }
    }
}
