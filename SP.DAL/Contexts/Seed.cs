using System;
using System.Linq;
using SP.DAL.Models;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlatMapper;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace SP.DAL.Contexts
{
    public class Seed
    {
        private const string MODELSNAMESPACE = "SP.DAL.Models";
        private static readonly string[] EXCLUDEClASSES = { "GeoNameTxt", "SPUser" };
        private const string METHODNAME = "GetGeoNames";
        private const string TEXTFILESFOLDERNAME = "\\PostalCodeDataTextFiles\\";
        private const string TEXTFILENAME = "{0}{1}{2}.txt";

        public static Dictionary<string, string> CredentialDictionary = new Dictionary<string, string>
        {
            {"chinnarao@live.com", "p@ssw0rd1111"}, {"revathi@live.com", "p@ssw0rd1111"}, {"riya@live.com", "p@ssw0rd1111"}, {"kavin@live.com", "p@ssw0rd1111"}, {"public@live.com", "p@ssw0rd1111"}
        };

        public static Dictionary<int, string> RoleDictionary = new Dictionary<int, string>
        {
            {1, "anonymous"}, {2, "authenticated"}, {3, "sitemanager"}, {4, "siteowner"}, {5, "administrator"}
        };

        public static void SeedTerritories(SPDbContext context)
        {
            bool IsDbCreated = context.Database.EnsureCreated();

            if (context.ZA_SouthAfrica.Any())
                return;
            List<KeyValuePair<string, string>> times = new List<KeyValuePair<string, string>>();
            Assembly.GetEntryAssembly().GetTypes()
                .Where(t => t.Namespace != null && t.Namespace.Equals(MODELSNAMESPACE) && !EXCLUDEClASSES.Contains(t.Name))
                .ToList<Type>()
                .ForEach(t => {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    MethodInfo mi = typeof(Seed).GetMethod(METHODNAME).MakeGenericMethod(t);
                   ((IEnumerable<object>)mi.Invoke( new Seed(), null)).ToList().ForEach(t1 => { context.Add(t1); });
                   int count = context.SaveChanges();
                    stopwatch.Stop();
                    times.Add(new KeyValuePair<string, string>(t.Name, string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed.ToString())));
                });

            if (times != null)
            {

            }
        }

        public List<T> GetGeoNames<T>()
        {
            List<ParserErrorInfo> ErrorInfos = new List<ParserErrorInfo>();
            List<Exception> Exceptions = new List<Exception>();
            Func<ParserErrorInfo, Exception, bool> HandleEntryReadError = (info, ex) =>
            {
                ErrorInfos.Add(info);
                Exceptions.Add(ex);
                return true;
            };

            Layout<GeoNameTxt> layout = new Layout<GeoNameTxt>.DelimitedLayout()
                .WithDelimiter("\t")
                .WithMember(o => o.countrycode)
                .WithMember(o => o.postalcode)
                .WithMember(o => o.placename)
                .WithMember(o => o.statename)
                .WithMember(o => o.statecode)
                .WithMember(o => o.countyorprovincename)
                .WithMember(o => o.countyorprovincecode)
                .WithMember(o => o.communityname)
                .WithMember(o => o.communitycode)
                .WithMember(o => o.latitude)
                .WithMember(o => o.longitude)
                .WithMember(o => o.accuracy);

            string CountryTextFilePath = string.Format(TEXTFILENAME, Directory.GetCurrentDirectory(), TEXTFILESFOLDERNAME, typeof(T).Name.Substring(0, 2));
            List<GeoNameTxt> GeoNameTxts = new List<GeoNameTxt>();
            using (var fileStream = File.OpenRead(CountryTextFilePath))
            {
                var flatfile = new FlatFile<GeoNameTxt>(layout, fileStream, Encoding.UTF8, HandleEntryReadError);
                foreach (var geoName in flatfile.Read())
                    GeoNameTxts.Add(geoName);
            }

            if (ErrorInfos.Count > 0 || Exceptions.Count > 0)
                throw new Exception();

            List<T> GeoNames = new List<T>();
            foreach (var geoName in GeoNameTxts)
            {
                object someCustomClassInstance = Activator.CreateInstance(typeof(T));
                foreach (PropertyInfo pi in typeof(T).GetProperties())
                {
                    var value = geoName.GetType().GetProperty(pi.Name).GetValue(geoName, null);
                    pi.SetValue(someCustomClassInstance, value);
                }
                GeoNames.Add((T)someCustomClassInstance);
            }

            ErrorInfos = null; Exceptions = null; layout = null; GeoNameTxts = null;

            return GeoNames;
        }

        public static async Task SeedRoles(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<SPDbContext>();

                if (!dbContext.UserRoles.Any())
                {
                    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                    foreach (var role in RoleDictionary)
                    {
                        if (!await roleManager.RoleExistsAsync(role.Value))
                        {
                            await roleManager.CreateAsync(new IdentityRole(role.Value));
                        }
                    }
                }

            }
        }

        public static async Task SeedUsers(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<SPDbContext>();
                if (!dbContext.Users.Any())
                {
                    var userManager = serviceProvider.GetService<UserManager<SPUser>>();
                    int roleId = 5;
                    foreach (var credential in CredentialDictionary)
                    {
                        SPUser spUser = await userManager.FindByNameAsync(credential.Key);
                        if (spUser == null)
                        {
                            spUser = new SPUser { UserName = credential.Key, Email = credential.Key, EmailConfirmed = true };
                            IdentityResult userResult = await userManager.CreateAsync(spUser, credential.Value);
                            if (userResult.Succeeded)
                            {
                                var result = await userManager.AddToRoleAsync(spUser, RoleDictionary[roleId--]);
                            }
                        }
                    }
                }
            }
        }
    }
}