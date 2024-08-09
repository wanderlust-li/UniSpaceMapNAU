using Microsoft.EntityFrameworkCore;
using UniSpaceMapNAU.Application.Interfaces;
using UniSpaceMapNAU.Domain.Entities;
using UniSpaceMapNAU.Infrastructure.Data;

namespace UniSpaceMapNAU.Infrastructure.Repository;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApplicationDbContext _context;
    private IRepository<Faculty> _facultyRepository;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public IRepository<Faculty> FaluctyRepository
    {
        get
        {
            if (_facultyRepository == null)
                _facultyRepository = new Repository<Faculty>(_context);
            return _facultyRepository;
        }
    }

    public async Task ExecuteSql(FormattableString query)
    {
        await _context.Database.ExecuteSqlRawAsync(query.ToString());
        //.SqlQuery();
    }

    public Task<int> SaveChangesAsync() => _context.SaveChangesAsync();
    
    private bool _disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
                _context.Dispose();
            this._disposed = true;
        }
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}