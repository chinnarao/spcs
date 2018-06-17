using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using SharpRaven.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP.Territories
{
    public class RavenLoggerProvider : ILoggerProvider, IDisposable
    {
        private readonly IRavenClient _client;
        private readonly LogLevel _minLevel;
        private readonly IHttpContextAccessor _accessor;

        public RavenLoggerProvider(IRavenClient client, LogLevel minLevel, IHttpContextAccessor accessor)
        {
            _client = client;
            _minLevel = minLevel;
            _accessor = accessor;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new RavenLogger(categoryName, _client, _accessor, _minLevel);
        }

        public void Dispose()
        {
        }
    }

    public static class RavenLoggerProviderExtensions
    {
        public static ILoggerFactory AddRavenLogger(this ILoggerFactory factory, IRavenClient client, IHttpContextAccessor accessor, LogLevel minLevel = LogLevel.Information)
        {
            factory.AddProvider(new RavenLoggerProvider(client, minLevel, accessor));
            return factory;
        }
    }

    public class RavenLogger : ILogger
    {
        public RavenLogger(string categoryName, IRavenClient _client, IHttpContextAccessor _accessor, LogLevel _minLevel)
        {

        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            throw new NotImplementedException();
        }
    }
}
