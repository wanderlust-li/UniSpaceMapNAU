using Microsoft.EntityFrameworkCore;
using UniSpaceMapNAU.Application.Interfaces;
using UniSpaceMapNAU.Domain.Entities;
using UniSpaceMapNAU.Infrastructure.Data;

namespace UniSpaceMapNAU.Infrastructure.Repository;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApplicationDbContext _context;
    private IRepository<Faculty> _facultyRepository;
    private IRepository<RoomType> _roomTypeRepository;
    private IRepository<Building> _buildingRepository;
    private IRepository<Department> _departmentRepository;
    private IRepository<Room> _roomRepository;

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

    public IRepository<RoomType> RoomTypeRepository
    {
        get
        {
            if (_roomTypeRepository == null)
                _roomTypeRepository = new Repository<RoomType>(_context);
            return _roomTypeRepository;
        }
    }

    public IRepository<Building> BuildingRepository
    {
        get
        {
            if (_buildingRepository == null)
                _buildingRepository = new Repository<Building>(_context);
            return _buildingRepository;
        }
    }

    public IRepository<Department> DepartmentRepository
    {
        get
        {
            if (_departmentRepository == null)
                _departmentRepository = new Repository<Department>(_context);
            return _departmentRepository;
        }
    }

    public IRepository<Room> RoomRepository
    {
        get
        {
            if (_roomRepository == null)
                _roomRepository = new Repository<Room>(_context);
            return _roomRepository;
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