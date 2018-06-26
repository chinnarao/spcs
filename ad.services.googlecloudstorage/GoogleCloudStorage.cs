using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ad.services.googlecloudstorage
{
    public class GoogleCloudStorage
    {
        public void UploadObject(string bucketName, Stream stream, string objectName)
        {
            if (string.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentException(nameof(bucketName));
            }
            if (stream == null || stream.Length <= 0)
            {
                throw new ArgumentException(nameof(stream));
            }
            if (string.IsNullOrEmpty(objectName))
            {
                throw new ArgumentException(nameof(objectName));
            }
            string fileExtenstion = Path.GetExtension(objectName);
            if (string.IsNullOrEmpty(fileExtenstion))
            {
                throw new ArgumentException(nameof(fileExtenstion));
            }
            string contentType = utility.utility.GetMimeTypes()[fileExtenstion.ToLower()];
            if (string.IsNullOrEmpty(contentType))
            {
                throw new ArgumentException(nameof(contentType));
            }
            var storage = StorageClient.Create();
            storage.UploadObject(bucketName, objectName, contentType, stream);
        }

        public async Task UploadObjectAsync(string bucketName, Stream stream, string objectName)
        {
            if (string.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentException(nameof(bucketName));
            }
            if (stream == null || stream.Length <= 0)
            {
                throw new ArgumentException(nameof(stream));
            }
            if (string.IsNullOrEmpty(objectName))
            {
                throw new ArgumentException(nameof(objectName));
            }
            string fileExtenstion = Path.GetExtension(objectName);
            if (string.IsNullOrEmpty(fileExtenstion))
            {
                throw new ArgumentException(nameof(fileExtenstion));
            }
            string contentType = utility.utility.GetMimeTypes()[fileExtenstion.ToLower()];
            if (string.IsNullOrEmpty(contentType))
            {
                throw new ArgumentException(nameof(contentType));
            }
            var storage = StorageClient.Create();
            await storage.UploadObjectAsync(bucketName, objectName, contentType, stream);
        }
    }

    public interface IGoogleCloudStorage
    {
        void UploadObject(string bucketName, Stream stream, string objectName);
        Task UploadObjectAsync(string bucketName, Stream stream, string objectName);
    }
}
