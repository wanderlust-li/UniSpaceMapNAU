using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace UniSpaceMapNAU.Application.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    Task<IList<TEntity>> GetAllAsync();
    Task<IList<TResult>> GetAllAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
        bool disableTracking = true,
        bool disableTrackingWithIdentityResolution = true,
        bool ignoreQueryFilters = false);
    IQueryable<TEntity> GetAll();
    public IQueryable<TEntity> List();
    Task SaveChangesAsync();
    Task<TEntity> GetById(object id);
    Task InsertAsync(params TEntity[] entities); 
    Task Delete(object id);
}