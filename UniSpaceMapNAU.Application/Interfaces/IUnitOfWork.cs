using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.Interfaces;

public interface IUnitOfWork
{
    IRepository<Faculty> FaluctyRepository { get; }
    IRepository<RoomType> RoomTypeRepository { get; }
    IRepository<Building> BuildingRepository { get; }
    IRepository<Department> DepartmentRepository { get; }
    IRepository<Room> RoomRepository { get; }
    Task ExecuteSql(FormattableString query);
    Task<int> SaveChangesAsync();
    
}