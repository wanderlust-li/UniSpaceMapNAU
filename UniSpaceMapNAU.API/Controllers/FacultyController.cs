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
    
    [HttpGet("get-all-faculties")]
    public async Task<IActionResult> GetAllFaculties() => 
        Ok(await _facultyService.GetAllFaculty());
    
    [HttpGet("get-faculty-by-id")]
    public async Task<IActionResult> GetFacultyById(int id) => 
        Ok(await _facultyService.GetFacultyById(id));

    [HttpGet("get-all-faculties-with-departments")]
    public async Task<IActionResult> GetAllFacultiesWithDepartments() => 
        Ok(await _facultyService.GetAllFacultiesWithDepartments());
    
    
}