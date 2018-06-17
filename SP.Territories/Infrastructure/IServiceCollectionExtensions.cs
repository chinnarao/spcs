using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SharpRaven.Core;
using SharpRaven.Core.Configuration;
using common;
using SP.DAL.Contexts;
using SP.DAL.Models;
using SP.DL.Infrastructure;
using SP.DL.Services;
using System;
using common.coremodels;

namespace SP.Territories
{
    public static class IServiceCollectionExtensions
    {
        //public static void SP(this IServiceCollection services, IConfigurationRoot Configuration)
        //{
            
        //    //services.AddApplicationInsightsTelemetry(Configuration);
        //    services.AddTransientSP();
        //    services.ConfigurePOCO(Configuration.GetSection("AppSettings"), () => new AppSettings());
        //}

        public static void SP(this IServiceCollection services, IConfiguration Configuration)
        {

            //services.AddApplicationInsightsTelemetry(Configuration);
            services.AddTransientSP();
            services.ConfigurePOCO(Configuration.GetSection("AppSettings"), () => new AppSettings());
        }

        public static void AddTransientSP(this IServiceCollection services)
        {
            services.AddTransient<ITerritoriesService, TerritoriesService>();
            services.AddTransient<IErrorHandler, ErrorHandler>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IRavenClient, RavenClient>();
        }

        public static TConfig ConfigurePOCO<TConfig>(this IServiceCollection services, IConfiguration configuration, Func<TConfig> pocoProvider) where TConfig : class
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            if (pocoProvider == null) throw new ArgumentNullException(nameof(pocoProvider));

            var config = pocoProvider();
            configuration.Bind(config);
            services.AddSingleton(config);
            return config;
        }

        //public static TConfig ConfigurePOCO<TConfig>(this IServiceCollection services, IConfiguration configuration, TConfig config) where TConfig : class
        //{
        //    if (services == null) throw new ArgumentNullException(nameof(services));
        //    if (configuration == null) throw new ArgumentNullException(nameof(configuration));
        //    if (config == null) throw new ArgumentNullException(nameof(config));

        //    configuration.Bind(config);
        //    services.AddSingleton(config);
        //    return config;
        //}
    }
}


