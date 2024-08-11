using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using UniSpaceMapNAU.Application.Interfaces;
using UniSpaceMapNAU.Infrastructure.Data;

namespace UniSpaceMapNAU.Infrastructure.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }
    
    public async Task<IList<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<IList<TResult>> GetAllAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
        bool disableTracking = true, bool disableTrackingWithIdentityResolution = true, bool ignoreQueryFilters = false)
    {
        IQueryable<TEntity> query = _dbSet;

        if (disableTracking)
        {
            query = query.AsNoTracking();
        }

        if (disableTrackingWithIdentityResolution && disableTracking)
        {
            query = query.AsNoTrackingWithIdentityResolution();
        }

        if (include != null)
        {
            query = include(query);
        }

        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        if (ignoreQueryFilters)
        {
            query = query.IgnoreQueryFilters();
        }


        if (orderBy != null)
        {
            return await orderBy(query).Select(selector).ToListAsync();
        }
        return await query.Select(selector).ToListAsync();
    }

    public IQueryable<TEntity> GetAll()
    {
        return _dbSet;
    }

    public IQueryable<TEntity> List()
    {
        return _dbSet;
    }

    public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    public virtual async Task<TEntity> GetById(object id)
    {
        return await _dbSet.FindAsync(id);
    }

    public Task InsertAsync(params TEntity[] entities) => _dbSet.AddRangeAsync(entities);

    public virtual async Task Delete(object id)
    {
        TEntity entityToDelete = _dbSet.Find(id);
        await Task.Run(() => Delete(entityToDelete));
    }

    public virtual async Task<TResult> GetFirstOrDefaultAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
        bool disableTracking = true, bool ignoreQueryFilters = false)
    {
        IQueryable<TEntity> query = _dbSet;

        if (disableTracking)
        {
            query = query.AsNoTracking();
        }

        if (include != null)
        {
            query = include(query);
        }

        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        if (ignoreQueryFilters)
        {
            query = query.IgnoreQueryFilters();
        }

        if (orderBy != null)
        {
            return await orderBy(query).Select(selector).FirstOrDefaultAsync();
        }
        else
        {
            return await query.Select(selector).FirstOrDefaultAsync();
        }
    }
}