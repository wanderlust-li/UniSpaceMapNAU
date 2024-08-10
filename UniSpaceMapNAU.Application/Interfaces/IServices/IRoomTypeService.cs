using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.Interfaces.IServices;

public interface IRoomTypeService
{
    Task<IEnumerable<RoomType>> GetAllRoomType();
    Task<RoomType> GetRoomTypeById(int id);
}