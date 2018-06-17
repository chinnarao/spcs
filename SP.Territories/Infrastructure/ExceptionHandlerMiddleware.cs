using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using SharpRaven.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SP.Territories
{
    public class ExceptionHandlerMiddleware
    {
        private readonly IRavenClient _client;
        private readonly RequestDelegate _next;
        private readonly TelemetryClient _telemetryClient;
        //private readonly ILogger _loggerFactory;

        public ExceptionHandlerMiddleware(RequestDelegate next, TelemetryClient telemetryClient,  IRavenClient client) //ILogger loggerFactory,
        {
            _next = next;
            _telemetryClient = telemetryClient;
            //_loggerFactory = loggerFactory;
            _client = client;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                //_loggerFactory.LogError(ex.Message);
                //_telemetryClient.TrackException(ex);
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(ex.StackTrace);
            }
        }
    }
}
