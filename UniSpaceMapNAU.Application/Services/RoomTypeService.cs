using UniSpaceMapNAU.Application.Interfaces;
using UniSpaceMapNAU.Application.Interfaces.IServices;
using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.Services;

public class RoomTypeService : IRoomTypeService
{
    private readonly IUnitOfWork _unitOfWork;

    public RoomTypeService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<RoomType>> GetAllRoomType() => 
        await _unitOfWork.RoomTypeRepository.GetAllAsync();
    
    public async Task<RoomType> GetRoomTypeById(int id) => 
        await _unitOfWork.RoomTypeRepository.GetById(id);
    
}