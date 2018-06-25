using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using ad.services;
using ad.services.db;
using Swashbuckle.AspNetCore.Swagger;
using ad.services.htmltemplate;
//https://github.com/dotnet-architecture/eShopOnWeb
//https://github.com/aspnet/Docs/blob/master/aspnetcore/test/integration-tests/samples/2.x/IntegrationTestsSample/src/RazorPagesProject/Startup.cs
//https://github.com/dotnet-presentations/home/tree/master/ASP.NET%20Core/ASP.NET%20Core%20-%20What-s%20New
namespace ad
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
            services.AddDbContext<AdDbContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddUnitOfWork<AdDbContext>();

            services.AddTransient<IAdService, AdService>();
            services.AddTransient<IFileReadService, FileReadService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            #region Swagger
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Ad API", Version = "v1" });
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            #region Swagger
            //http://localhost:<port>/swagger
            //http://localhost:<port>/swagger/v1/swagger.json
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {

                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });
            #endregion

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
