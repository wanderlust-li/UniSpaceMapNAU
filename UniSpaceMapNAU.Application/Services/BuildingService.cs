using UniSpaceMapNAU.Application.Interfaces;
using UniSpaceMapNAU.Application.Interfaces.IServices;
using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.Services;

public class BuildingService : IBuildingService
{
    private readonly IUnitOfWork _unitOfWork;

    public BuildingService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<Building>> GetAllBuilding() =>
        await _unitOfWork.BuildingRepository.GetAllAsync();
    

    public async Task<Building> GetBuildingById(int id) =>
        await _unitOfWork.BuildingRepository.GetById(id);
    
}