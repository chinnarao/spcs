using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP.Territories
{
    public static class ILoggerFactoryExtensions
    {
        public static void SP(this ILoggerFactory loggerFactory)
        {
            string pathFormat = "Logs/log-{Date}.txt";
            var levelOverrides = new Dictionary<string, LogLevel>() { { "System", LogLevel.Information }, { "Microsoft", LogLevel.Information } };
            loggerFactory.AddFile(pathFormat, minimumLevel: LogLevel.Information, levelOverrides : levelOverrides, isJson: true);
        }
    }
}
