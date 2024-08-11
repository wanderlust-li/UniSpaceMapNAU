using Microsoft.AspNetCore.Mvc;
using UniSpaceMapNAU.Application.Interfaces.IServices;

namespace UniSpaceMapNAU.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BuildingController : ControllerBase
{
    private readonly IBuildingService _buildingService;

    public BuildingController(IBuildingService buildingService)
    {
        _buildingService = buildingService;
    }

    [HttpGet("get-all-building")]
    public async Task<IActionResult> GetAllBuilding() =>
        Ok(await _buildingService.GetAllBuilding());

    [HttpGet("get-building-by-id")]
    public async Task<IActionResult> GetBuildingById(int id) =>
        Ok(await _buildingService.GetBuildingById(id));
}