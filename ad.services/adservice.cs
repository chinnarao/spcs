using common.admodels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace ad.services
{
    public class AdService: IAdService
    {
        //private readonly IUnitOfWork _unitOfWork;

        //public AdService(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}

        //public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : AdVM, new()
        //{
        //    return _unitOfWork.GetRepository<TEntity>()
        //        .GetPagedList().Items.Distinct();
        //}
    }

    public interface IAdService
    {
        //IEnumerable<TEntity> GetAll<TEntity>() where TEntity : AdVM, new();
    }
}
