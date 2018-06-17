using Microsoft.AspNetCore.Http;
using Serilog;
using Serilog.Events;
using SharpRaven.Core;
using SharpRaven.Core.Data;
using common;
using SP.DL.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using extensions;
using common.coremodels;

//http://blog.getseq.net/smart-logging-middleware-for-asp-net-core/
namespace SP.Territories
{
    class SerilogMiddleware
    {
        private const string MessageTemplate = "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms";

        static readonly ILogger Log = Serilog.Log.ForContext<SerilogMiddleware>();

        private readonly RequestDelegate _next;
        private readonly IRavenClient _RavenClient;
        private readonly AppSettings _AppSettings;
        private readonly IEmailService _EmailService;
        public SerilogMiddleware(RequestDelegate next, IRavenClient ravenClient, AppSettings appSettings, IEmailService EmailService)
        {
            if (next == null) throw new ArgumentNullException(nameof(next));
            _next = next;
            _RavenClient = ravenClient;
            _AppSettings = appSettings;
            _EmailService = EmailService;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext == null) throw new ArgumentNullException(nameof(httpContext));

            var sw = Stopwatch.StartNew();
            try
            {
                await _next(httpContext);
                sw.Stop();

                var statusCode = httpContext.Response?.StatusCode;
                var level = statusCode > 499 ? LogEventLevel.Error : LogEventLevel.Information;

                var log = level == LogEventLevel.Error ? LogForErrorContext(httpContext) : Log;
                log.Write(level, MessageTemplate, httpContext.Request.Method, httpContext.Request.Path, statusCode, sw.Elapsed.TotalMilliseconds);
            }
            // Never caught, because `LogException()` returns false.
            catch (Exception ex) when (LogException(httpContext, sw, ex)){  }
        }

        bool LogException(HttpContext httpContext, Stopwatch sw, Exception ex)
        {
            sw.Stop();

            LogForErrorContext(httpContext).Error(ex, MessageTemplate, httpContext.Request.Method, httpContext.Request.Path, 500, sw.Elapsed.TotalMilliseconds);
            if (_AppSettings.IsPostSentryWhenErrorOccured)
                SentryLogAsync(ex);
            if (_AppSettings.IsEmailSendWhenErrorOccured)
                SendEmailAsync(ex);
            return false;
        }

        static ILogger LogForErrorContext(HttpContext httpContext)
        {
            var request = httpContext.Request;

            var result = Log
                .ForContext("RequestHeaders", request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString()), destructureObjects: true)
                .ForContext("RequestHost", request.Host)
                .ForContext("RequestProtocol", request.Protocol);

            if (request.HasFormContentType)
                result = result.ForContext("RequestForm", request.Form.ToDictionary(v => v.Key, v => v.Value.ToString()));

            return result;
        }

        private async  void SentryLogAsync(Exception exception)
        {
            try
            {
                await _RavenClient.CaptureAsync(new SentryEvent(exception));
            }
            catch { }
        }

        private async void SendEmailAsync(Exception exception)
        {
            try
            {
                await _EmailService.SendEmailAsync("sperror@scooppages.com", "chinnarao@live.com",exception.ToLogString(nameof(SerilogMiddleware)), "error occured");
            }
            catch { }
        }
    }
}