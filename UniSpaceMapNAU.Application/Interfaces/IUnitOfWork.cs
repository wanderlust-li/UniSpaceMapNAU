using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.Interfaces;

public interface IUnitOfWork
{
    IRepository<Faculty> FaluctyRepository { get; }
    IRepository<RoomType> RoomTypeRepository { get; }
    Task ExecuteSql(FormattableString query);
    Task<int> SaveChangesAsync();
    
}