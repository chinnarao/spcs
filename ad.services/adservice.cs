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

        //public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : AdVM, new()
        //{
        //    return _unitOfWork.GetRepository<TEntity>()
        //        .GetPagedList().Items.Distinct();
        //}
        public string GetAdHtmlFileTemplateContent(string fileName, int inMemoryCachyExpireDays)
        {
            return _fileReadService.FileAsString(fileName, inMemoryCachyExpireDays);
        }

        public Stream GetAdHtmlFileTemplateStream(string fileName, int inMemoryCachyExpireDays, object anonymousDataObject)
        {
            string content = this.GetAdHtmlFileTemplateContent(fileName, inMemoryCachyExpireDays);
            content = this.SetAdHtmlFileTemplateContent(content, anonymousDataObject);
            return _fileReadService.FileAsStream(content);
        }

        public string SetAdHtmlFileTemplateContent(string content, object anonymousDataObject)
        {
            return _fileReadService.FillContent(content, anonymousDataObject);
        }

        public void UploadObjectInGoogleCloudStorage(string bucketName, Stream stream, string objectName)
        {
            _googleCloudStorage.UploadObject(bucketName, stream, objectName);
        }

        public async Task UploadObjectInGoogleCloudStorageAsync(string bucketName, Stream stream, string objectName)
        {
            await _googleCloudStorage.UploadObjectAsync(bucketName, stream, objectName);
        }

        public void UploadObjectInGoogleCloudStorage(string fileName, int inMemoryCachyExpireDays, string objectName, object anonymousDataObject,  string bucketName)
        {
            string content = this.GetAdHtmlFileTemplateContent(fileName, inMemoryCachyExpireDays);
            content = this.SetAdHtmlFileTemplateContent(content, anonymousDataObject);
            Stream stream = this.GetAdHtmlFileTemplateStream(fileName, inMemoryCachyExpireDays, anonymousDataObject);
            this.UploadObjectInGoogleCloudStorage(bucketName, stream, objectName);
        }
    }

    public interface IAdService
    {
        string GetAdHtmlFileTemplateContent(string fileName, int inMemoryCachyExpireDays);
        string SetAdHtmlFileTemplateContent(string content, object anonymousDataObject);
        Stream GetAdHtmlFileTemplateStream(string fileName, int inMemoryCachyExpireDays, object anonymousDataObject);
        void UploadObjectInGoogleCloudStorage(string bucketName, Stream stream, string objectName);
        void UploadObjectInGoogleCloudStorage(string fileName, int inMemoryCachyExpireDays, string objectName, object anonymousDataObject, string bucketName);
        Task UploadObjectInGoogleCloudStorageAsync(string bucketName, Stream stream, string objectName);
        //IEnumerable<TEntity> GetAll<TEntity>() where TEntity : AdVM, new();
    }
}
