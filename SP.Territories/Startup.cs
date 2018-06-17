using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//using SP.Api.Repositories.Things;
//using SP.Api.Models;
//using SP.DAL.Contexts;
//using SP.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SP.DAL.Contexts;
using SP.DL.Services;
using SP.DL.Infrastructure;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using SP.DAL.Models;
using AutoMapper;
using SharpRaven.Core.Configuration;
using SharpRaven.Core;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SP.Territories
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            //http://www.talkingdotnet.com/response-caching-in-asp-net-core-1-1/
            //services.AddResponseCaching();
            services.AddDistributedSqlServerCache(o =>
            {
                o.ConnectionString = Configuration.GetConnectionString("DefaultConnection");
                o.SchemaName = "dbo";
                o.TableName = "Cache";
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddEntityFramework(Configuration.GetConnectionString("DefaultConnection"));
            services.AddUnitOfWork<SPDbContext>();
            services.Configure<RavenOptions>(Configuration.GetSection("RavenOptions"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IRavenClient, RavenClient>((s) =>
            {
                var rc = new RavenClient(s.GetRequiredService<IOptions<RavenOptions>>(), s.GetRequiredService<IHttpContextAccessor>())
                {
                    Environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
                };
                return rc;
            });
            services.AddIdentity<SPUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<SPDbContext>();
            //services.AddMvc();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.CookieHttpOnly = true;
            });
            services.SP(Configuration);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            

            string pathFormat = "Logs/log-{Date}.txt";
            var levelOverrides = new Dictionary<string, LogLevel>() { { "System", LogLevel.Information }, { "Microsoft", LogLevel.Information } };
            loggerFactory.AddFile(pathFormat, minimumLevel: LogLevel.Information, levelOverrides: levelOverrides, isJson: false);

            //app.UseMvc();
            var angularRoutes = new[] {
                 "/home",
                 "/about"
             };

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.HasValue && null != angularRoutes.FirstOrDefault(
                    (ar) => context.Request.Path.Value.StartsWith(ar, StringComparison.OrdinalIgnoreCase)))
                {
                    context.Request.Path = new PathString("/");
                }

                await next();
            });

            //app.UseCors("AllowAllOrigins");

            //app.UseDefaultFiles();
            //app.UseStaticFiles();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
            app.UseHttpsRedirection();
            //app.UseMvc();
            app.SP(env, loggerFactory);
        }
    }

    public class Startup11111
    {
        public Startup11111(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            //http://www.talkingdotnet.com/response-caching-in-asp-net-core-1-1/
            //services.AddResponseCaching();
            services.AddDistributedSqlServerCache(o =>
            {
                o.ConnectionString = Configuration.GetConnectionString("DefaultConnection");
                o.SchemaName = "dbo";
                o.TableName = "Cache";
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddEntityFramework(Configuration.GetConnectionString("DefaultConnection"));
            services.AddUnitOfWork<SPDbContext>();
            services.Configure<RavenOptions>(Configuration.GetSection("RavenOptions"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IRavenClient, RavenClient>((s) =>
            {
                var rc = new RavenClient(s.GetRequiredService<IOptions<RavenOptions>>(), s.GetRequiredService<IHttpContextAccessor>())
                {
                    Environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
                };
                return rc;
            });
            services.AddIdentity<SPUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<SPDbContext>();
            services.AddMvc();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.CookieHttpOnly = true;
            });
            services.SP(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            string pathFormat = "Logs/log-{Date}.txt";
            var levelOverrides = new Dictionary<string, LogLevel>() { { "System", LogLevel.Information }, { "Microsoft", LogLevel.Information } };
            loggerFactory.AddFile(pathFormat, minimumLevel: LogLevel.Information, levelOverrides: levelOverrides, isJson: false);

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    //app.UseBrowserLink();
            //}
            //else
            //{
            //    //app.UseExceptionHandler("/Home/Error");  this is not working
            //    app.UseExceptionHandler(
            //        options =>
            //        {
            //            options.Run(
            //            async context =>
            //            {
            //                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            //                context.Response.ContentType = "text/html";
            //                var ex = context.Features.Get<IExceptionHandlerFeature>();
            //                if (ex != null)
            //                {
            //                    var err = $"<h1>Error: {ex.Error.Message}</h1>{ex.Error.StackTrace }";
            //                    await context.Response.WriteAsync(err).ConfigureAwait(false);
            //                }
            //            });
            //        }
            //    );
            //}
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();

            var angularRoutes = new[] {
                 "/home",
                 "/about"
             };

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.HasValue && null != angularRoutes.FirstOrDefault(
                    (ar) => context.Request.Path.Value.StartsWith(ar, StringComparison.OrdinalIgnoreCase)))
                {
                    context.Request.Path = new PathString("/");
                }

                await next();
            });

            app.UseCors("AllowAllOrigins");

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
