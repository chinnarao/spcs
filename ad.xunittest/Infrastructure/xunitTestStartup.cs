using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ad.xunittest
{
    public class XunitTestStartup : ad.Startup
    {
        public XunitTestStartup(IConfiguration configuration) : base(configuration)
        {
        }

        /*  you may want to replace some service using DI. 
            ASP.NET provides mecanisms to support multiple environments. 
            For instance, you can create one Configure<Environment name>Services method per environment. 
            If no method is defined for the environment, the ConfigureServices will be used. 
            One way to personalize the DI for testing is to create a class that inherits from Startup and add the method ConfigureTestServices
         */
        public void ConfigureTestServices(IServiceCollection services)
        {
        }

        public void ConfigureTest(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
