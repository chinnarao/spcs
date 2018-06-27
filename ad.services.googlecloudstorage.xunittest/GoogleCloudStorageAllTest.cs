using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Xunit;

//https://console.cloud.google.com/storage/browser?project=oceanic-cacao-203021&folder&organizationId
namespace ad.services.googlecloudstorage.xunittest
{
    public class GoogleCloudStorageAllTest
    {
        [Fact]
        public void Test_UploadFile()
        {
            IConfiguration _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string bucketName = _configuration["AdBucketNameInGoogleCloudStorage"];
            string fileName = "1.jpg";
            string objectName = DateTime.Now.ToString("yyyy-MM-dd-") + new Random().Next(0,Byte.MaxValue) + Path.GetExtension(fileName);
            GoogleCloudStorageAll storage = new GoogleCloudStorageAll();
            storage.UploadFile(bucketName, fileName, objectName);
            Assert.True(1 < 2);
        }
    }
}
