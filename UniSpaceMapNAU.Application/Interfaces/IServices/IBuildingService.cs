using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.Interfaces.IServices;

public interface IBuildingService
{
    Task<IEnumerable<Building>> GetAllBuilding();
    Task<Building> GetBuildingById(int id);
}