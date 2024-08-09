using Microsoft.AspNetCore.Mvc;
using UniSpaceMapNAU.Application.Interfaces.IServices;

namespace UniSpaceMapNAU.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FacultyController : ControllerBase
{
    private readonly IFacultyService _facultyService;

    public FacultyController(IFacultyService facultyService)
    {
        _facultyService = facultyService;
    }

    [HttpGet("get-all-faculty")]
    public async Task<IActionResult> GetAllFaculty()
    {
        return Ok(await _facultyService.GetAllFaculty());
    }
}