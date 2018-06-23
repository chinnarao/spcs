using Google.Apis.Storage.v1.Data;
using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ad.store
{
    public class GoogleCloudStore
    {
        private static readonly string s_projectId = "oceanic-cacao-203021";

        public void CreateBucket(string bucketName)
        {
            var storage = StorageClient.Create();
            storage.CreateBucket(s_projectId, bucketName);
            Console.WriteLine($"Created {bucketName}.");
        }
        public void CreateRegionalBucket(string location, string bucketName)
        {
            var storage = StorageClient.Create();
            Bucket bucket = new Bucket { Location = location, Name = bucketName };
            storage.CreateBucket(s_projectId, bucket);
            Console.WriteLine($"Created {bucketName}.");
        }
        public void ListBuckets()
        {
            var storage = StorageClient.Create();
            foreach (var bucket in storage.ListBuckets(s_projectId))
            {
                Console.WriteLine(bucket.Name);
            }
        }
        public void DeleteBucket(string bucketName)
        {
            var storage = StorageClient.Create();
            storage.DeleteBucket(bucketName);
            Console.WriteLine($"Deleted {bucketName}.");
        }
        public void ListObjects(string bucketName)
        {
            var storage = StorageClient.Create();
            foreach (var bucket in storage.ListObjects(bucketName, ""))
            {
                Console.WriteLine(bucket.Name);
            }
        }
        public void ListObjects(string bucketName, string prefix,
            string delimiter)
        {
            var storage = StorageClient.Create();
            var options = new ListObjectsOptions() { Delimiter = delimiter };
            foreach (var storageObject in storage.ListObjects(
                bucketName, prefix, options))
            {
                Console.WriteLine(storageObject.Name);
            }
        }
        public void UploadFile(string bucketName, string localPath,
            string objectName = null)
        {
            var storage = StorageClient.Create();
            using (var f = File.OpenRead(localPath))
            {
                objectName = objectName ?? Path.GetFileName(localPath);
                storage.UploadObject(bucketName, objectName, null, f);
                Console.WriteLine($"Uploaded {objectName}.");
            }
        }
        public void DeleteObject(string bucketName, IEnumerable<string> objectNames)
        {
            var storage = StorageClient.Create();
            foreach (string objectName in objectNames)
            {
                storage.DeleteObject(bucketName, objectName);
                Console.WriteLine($"Deleted {objectName}.");
            }
        }
        public void DownloadObject(string bucketName, string objectName,
            string localPath = null)
        {
            var storage = StorageClient.Create();
            localPath = localPath ?? Path.GetFileName(objectName);
            using (var outputFile = File.OpenWrite(localPath))
            {
                storage.DownloadObject(bucketName, objectName, outputFile);
            }
            Console.WriteLine($"downloaded {objectName} to {localPath}.");
        }
        public void GetMetadata(string bucketName, string objectName)
        {
            var storage = StorageClient.Create();
            var storageObject = storage.GetObject(bucketName, objectName);
            Console.WriteLine($"Bucket:\t{storageObject.Bucket}");
            Console.WriteLine($"CacheControl:\t{storageObject.CacheControl}");
            Console.WriteLine($"ComponentCount:\t{storageObject.ComponentCount}");
            Console.WriteLine($"ContentDisposition:\t{storageObject.ContentDisposition}");
            Console.WriteLine($"ContentEncoding:\t{storageObject.ContentEncoding}");
            Console.WriteLine($"ContentLanguage:\t{storageObject.ContentLanguage}");
            Console.WriteLine($"ContentType:\t{storageObject.ContentType}");
            Console.WriteLine($"Crc32c:\t{storageObject.Crc32c}");
            Console.WriteLine($"ETag:\t{storageObject.ETag}");
            Console.WriteLine($"Generation:\t{storageObject.Generation}");
            Console.WriteLine($"Id:\t{storageObject.Id}");
            Console.WriteLine($"Kind:\t{storageObject.Kind}");
            Console.WriteLine($"KmsKeyName:\t{storageObject.KmsKeyName}");
            Console.WriteLine($"Md5Hash:\t{storageObject.Md5Hash}");
            Console.WriteLine($"MediaLink:\t{storageObject.MediaLink}");
            Console.WriteLine($"Metageneration:\t{storageObject.Metageneration}");
            Console.WriteLine($"Name:\t{storageObject.Name}");
            Console.WriteLine($"Size:\t{storageObject.Size}");
            Console.WriteLine($"StorageClass:\t{storageObject.StorageClass}");
            Console.WriteLine($"TimeCreated:\t{storageObject.TimeCreated}");
            Console.WriteLine($"Updated:\t{storageObject.Updated}");
        }
        public void GetBucketMetadata(string bucketName)
        {
            var storage = StorageClient.Create();
            var storageObject = storage.GetBucket(bucketName);
            Console.WriteLine($"Bucket:\t{storageObject.Name}");
            Console.WriteLine($"Acl:\t{storageObject.Acl}");
            Console.WriteLine($"Billing:\t{storageObject.Billing}");
            Console.WriteLine($"Cors:\t{storageObject.Cors}");
            Console.WriteLine($"DefaultEventBasedHold:\t{storageObject.DefaultEventBasedHold}");
            Console.WriteLine($"DefaultObjectAcl:\t{storageObject.DefaultObjectAcl}");
            Console.WriteLine($"Encryption:\t{storageObject.Encryption}");
            if (storageObject.Encryption != null)
            {
                Console.WriteLine($"KmsKeyName:\t{storageObject.Encryption.DefaultKmsKeyName}");
            }
            Console.WriteLine($"Id:\t{storageObject.Id}");
            Console.WriteLine($"Kind:\t{storageObject.Kind}");
            Console.WriteLine($"Lifecycle:\t{storageObject.Lifecycle}");
            Console.WriteLine($"Location:\t{storageObject.Location}");
            Console.WriteLine($"Logging:\t{storageObject.Logging}");
            Console.WriteLine($"Metageneration:\t{storageObject.Metageneration}");
            Console.WriteLine($"Owner:\t{storageObject.Owner}");
            Console.WriteLine($"ProjectNumber:\t{storageObject.ProjectNumber}");
            Console.WriteLine($"RetentionPolicy:\t{storageObject.RetentionPolicy}");
            Console.WriteLine($"SelfLink:\t{storageObject.SelfLink}");
            Console.WriteLine($"StorageClass:\t{storageObject.StorageClass}");
            Console.WriteLine($"TimeCreated:\t{storageObject.TimeCreated}");
            Console.WriteLine($"Updated:\t{storageObject.Updated}");
            Console.WriteLine($"Versioning:\t{storageObject.Versioning}");
            Console.WriteLine($"Website:\t{storageObject.Website}");
        }
    }
}
