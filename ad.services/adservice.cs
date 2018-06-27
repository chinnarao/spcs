using ad.services.googlecloudstorage;
using ad.services.htmltemplate;
using common.admodels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ad.services
{
    public class AdService : IAdService
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IFileReadService _fileReadService;
        private readonly IGoogleCloudStorage _googleCloudStorage;

        public AdService(IFileReadService fileReadService, IGoogleCloudStorage googleCloudStorage)
        {
            _fileReadService = fileReadService;
            _googleCloudStorage = googleCloudStorage;
        }

        public async Task UploadObjectInGoogleCloudStorageAsync(string bucketName, Stream stream, string objectName)
        {
            await _googleCloudStorage.UploadObjectAsync(bucketName, stream, objectName);
        }

        public void UploadObjectInGoogleCloudStorage(string fileName, int inMemoryCachyExpireDays, string objectName, string bucketName, object anonymousDataObject)
        {
            string content = _fileReadService.FileAsString(fileName, inMemoryCachyExpireDays);
            content = _fileReadService.FillContent(content, anonymousDataObject);
            Stream stream = _fileReadService.FileAsStream(content);
            _googleCloudStorage.UploadObject(bucketName, stream, objectName);
        }
    }

    public interface IAdService
    {
        void UploadObjectInGoogleCloudStorage(string fileName, int inMemoryCachyExpireDays, string objectName, string bucketName, object anonymousDataObject);
        Task UploadObjectInGoogleCloudStorageAsync(string bucketName, Stream stream, string objectName);
        //IEnumerable<TEntity> GetAll<TEntity>() where TEntity : AdVM, new();
    }
}
