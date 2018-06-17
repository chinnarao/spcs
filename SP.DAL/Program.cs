using Microsoft.EntityFrameworkCore;
using SP.DAL.Contexts;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace SP.DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Seed.SeedTerritories(new SPDbContext(new DbContextOptionsBuilder<SPDbContext>().UseSqlServer(AppSettings.DefaultConnection).Options));
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

        public static Dictionary<string, string> GetCountries()
        {
            List<string> GeoNames = GetCountryCodesFromGeoNames();
            Dictionary<string, string> countryNamesFromJson = GetTerritoriesJson();
            Dictionary<string, string> GeoCountries = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> kvp in countryNamesFromJson)
                if (GeoNames.Contains(kvp.Key))
                    GeoCountries.Add(kvp.Key, kvp.Value);
            return GeoCountries;
        }

        public static List<string> GetCountryCodesFromGeoNames()
        {
            string folderName = Directory.GetCurrentDirectory() + "\\PostalCodeDataTextFiles";
            var files = Directory.GetFiles(folderName, "*", SearchOption.TopDirectoryOnly);
            var txtFiles = files.Where(a => a.EndsWith(".txt")).Select(a => Path.GetFileNameWithoutExtension(a)).ToList();
            return txtFiles;
        }

        public static Dictionary<string, string> GetTerritoriesJson()
        {
            Dictionary<string, string> details = new Dictionary<string, string>();
            JObject jobj = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Contexts\\Territories.json"));
            foreach (KeyValuePair<string, JToken> kvp in jobj)
                details.Add(kvp.Key, kvp.Value.ToString());
            return details;
        }

        /// <summary>
        /// {"AD", "AD_Andorra"} format
        /// </summary>
        public static void TerritoryStringWithUnderscore()
        {
            List<string> list = new List<string>();
            Dictionary<string, string> dict = GetCountries();
            foreach (var item in dict)
            {
                list.Add(string.Format("{0}=={1}==, =={2}=={3}", "{", item.Key, string.Format("{0}_{1}", item.Key, item.Value.Replace(" ", "")), "}"));
            }
            string commaStr = string.Join(",", list).Replace("\"", "\\\"");
        }

        public static void TerritoryString()
        {
            List<string> list = new List<string>();
            Dictionary<string, string> dict = GetCountries();
            foreach (var item in dict)
            {
                list.Add(string.Format("{0}=={1}==, =={2}=={3}", "{", item.Key, item.Value.Replace(" ", ""), "}"));
            }
            string commaStr = string.Join(",", list).Replace("\"", "\\\"");
        }

        public static bool AreZipAndTxtEqual()
        {
            //Environment.CurrectDirectory
            string folderName = Directory.GetCurrentDirectory() + "\\PostalCodeDataTextFiles";
            var files = Directory.GetFiles(folderName, "*", SearchOption.TopDirectoryOnly);
            var zipFiles = files.Where(a => a.EndsWith(".zip")).Select(a => Path.GetFileNameWithoutExtension(a)).ToList().Where(a => !a.EndsWith("csv")).ToList();
            var txtFiles = files.Where(a => a.EndsWith(".txt")).Select(a => Path.GetFileNameWithoutExtension(a)).ToList();
            var intersection = zipFiles.Intersect<string>(txtFiles);
            if (zipFiles.Count == txtFiles.Count && txtFiles.Count == intersection.Count())
                return true;
            return false;
        }
    }
}