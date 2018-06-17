using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SP.DAL.Contexts
{
    // if we do not use this class then migration will fail and shows the below error message.
    //No parameterless constructor was found on 'SPDbContext'. Either add a parameterless constructor to 'SPDbContext' or add an implementation of 'IDbContextFactory<SPDbContext>' in the same assembly as 'SPDbContext'.
    public class DataContextFactory : IDesignTimeDbContextFactory<SPDbContext>
    {
        public SPDbContext Create(DbContextFactoryOptions options)
        {
            return new SPDbContext(new DbContextOptionsBuilder<SPDbContext>().UseSqlServer(AppSettings.DefaultConnection).Options);
        }

        public SPDbContext Create(string[] args)
        {
            return new SPDbContext(new DbContextOptionsBuilder<SPDbContext>().UseSqlServer(AppSettings.DefaultConnection).Options);
        }

        SPDbContext IDesignTimeDbContextFactory<SPDbContext>.CreateDbContext(string[] args)
        {
            throw new System.NotImplementedException();
        }

        public static AppSettings AppSettings
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
                IConfigurationRoot configuration = builder.Build();
                var appSettings = new AppSettings();
                configuration.GetSection("AppSettings").Bind(appSettings);
                return appSettings;
            }
        }
    }
}
