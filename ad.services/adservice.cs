using ad.services.htmltemplate;
using common.admodels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace ad.services
{
    public class AdService : IAdService
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IFileReadService _fileReadService;
        public AdService(IFileReadService fileReadService)
        {
            _fileReadService = fileReadService;
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
    }

    public interface IAdService
    {
        string GetAdHtmlFileTemplateContent(string fileName, int inMemoryCachyExpireDays);
        //IEnumerable<TEntity> GetAll<TEntity>() where TEntity : AdVM, new();
    }
}
