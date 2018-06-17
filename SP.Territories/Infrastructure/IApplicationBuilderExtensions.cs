using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP.Territories
{
    //public static class SPMiddlewareExtensions
    //{
    //    public static IApplicationBuilder SPMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<SPMiddlewareExtensions>();
    //    }

    //    public static IApplicationBuilder UseMyMiddlewareWithParams(
    //        this IApplicationBuilder builder, MyMiddlewareOptions myMiddlewareOptions)
    //    {
    //        return builder.UseMiddleware<MyMiddlewareWithParams>(
    //            new OptionsWrapper<MyMiddlewareOptions>(myMiddlewareOptions));
    //    }
    //}

    //public static class MyMiddlewareWithParamsExtensions
    //{
    //    public static IApplicationBuilder UseMyMiddlewareWithParams(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<MyMiddlewareWithParams>();
    //    }

    //    public static IApplicationBuilder UseMyMiddlewareWithParams( this IApplicationBuilder builder, MyMiddlewareOptions myMiddlewareOptions)
    //    {
    //        return builder.UseMiddleware<MyMiddlewareWithParams>(new OptionsWrapper<MyMiddlewareOptions>(myMiddlewareOptions));
    //    }
    //}

    //public class MyMiddlewareWithParams
    //{
    //    private readonly RequestDelegate _next;
    //    private readonly MyMiddlewareOptions _myMiddlewareOptions;

    //    public MyMiddlewareWithParams(RequestDelegate next, IOptions<MyMiddlewareOptions> optionsAccessor)
    //    {
    //        _next = next;
    //        _myMiddlewareOptions = optionsAccessor.Value;
    //    }

    //    public async Task Invoke(HttpContext context)
    //    {
    //        // Do something with context near the beginning of request processing
    //        // using configuration in _myMiddlewareOptions

    //        await _next.Invoke(context);

    //        // Do something with context near the end of request processing
    //        // using configuration in _myMiddlewareOptions
    //    }
    //}

    //public class MyMiddlewareOptions
    //{
    //    public string Param1 { get; set; }
    //    public string Param2 { get; set; }
    //}

    //public class SecurityMiddleware
    //{
    //    private readonly RequestDelegate _next;

    //    public SecurityMiddleware(RequestDelegate next)
    //    {
    //        _next = next;
    //    }

    //    public Task Invoke(HttpContext httpContext)
    //    {
    //        httpContext.Response.Headers.Add("X-Xss-Protection", "1");
    //        httpContext.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
    //        httpContext.Response.Headers.Add("X-Content-Type-Options", "nosniff");
    //        return _next(httpContext);
    //    }
    //}

    //public static class SecurityMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseSecurityMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<SecurityMiddleware>();
    //    }
    //}

    public static class IApplicationBuilderExtensions
    {
        public static void SP(this IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();
            //env.EnvironmentName = EnvironmentName.Production;

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

            //app.UseExceptionHandler(
            //         builder =>
            //         {
            //             builder.Run(
            //             async context =>
            //             {
            //                 context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            //                 context.Response.ContentType = "application/json";
            //                 var ex = context.Features.Get<IExceptionHandlerFeature>();
            //                 if (ex != null)
            //                 {
            //                     var err = JsonConvert.SerializeObject(new Error()
            //                     {
            //                         Stacktrace = ex.Error.StackTrace,
            //                         Message = ex.Error.Message
            //                     });
            //                     await context.Response.Body.WriteAsync(Encoding.ASCII.GetBytes(err), 0, err.Length).ConfigureAwait(false);
            //                 }
            //             });
            //         }
            //    );

            //app.Use(async (context, next) =>
            //{
            //    await next.Invoke();

            //    //After going down the pipeline check if we 404'd. 
            //    if (context.Response.StatusCode == StatusCodes.Status404NotFound)
            //    {
            //        await context.Response.WriteAsync("Woops! We 404'd");
            //    }
            //});
            //app.UseSession();
            //app.UseMiddleware<Infrastructure.ExceptionHandlerMiddleware>();
            ////app.UseApplicationInsightsRequestTelemetry();
            //app.UseMvcWithDefaultRoute();
            app.UseCors("AllowAllOrigins");
            app.UseSession();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseBrowserLink();
            //}
            //else
            //{
            //    //app.UseExceptionHandler("/Home/Error");
            //    app.UseStatusCodePagesWithReExecute("/Home/Error");
            //}

            //app.UseMiddleware<StartTimeHeader>();
            app.UseMiddleware<SerilogMiddleware>();
            //app.UseMiddleware<Infrastructure.ExceptionHandlerMiddleware>();

            app.UseIdentity();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            // the below both are same
            app.UseMvcWithDefaultRoute();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
