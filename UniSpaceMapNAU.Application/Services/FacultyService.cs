using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using UniSpaceMapNAU.Application.DTOs.Faculty;
using UniSpaceMapNAU.Application.Interfaces;
using UniSpaceMapNAU.Application.Interfaces.IServices;
using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.Services;

public class FacultyService : IFacultyService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FacultyService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<FacultyDTO>> GetAllFaculty()
    {
        return await _unitOfWork.FaluctyRepository
            .List()
            .AsNoTracking()
            .ProjectTo<FacultyDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }

    public async Task<IEnumerable<FacultyWithDepartmentDTO>> GetAllFacultiesWithDepartments()
    {
        return await _unitOfWork.FaluctyRepository.List()
            .AsNoTracking()
            .Include(s => s.Departments)
            .ProjectTo<FacultyWithDepartmentDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }

    public async Task<FacultyDTO> GetFacultyById(int id)
    {
        return _mapper.Map<FacultyDTO>(await _unitOfWork.FaluctyRepository.GetById(id));
    }

    public async Task<List<FacultyWithDepartmentDTO>> GetFacultyByIdWithDepartments(int id)
    {
        return await _unitOfWork.FaluctyRepository.List()
            .Include(d => d.Departments)
            .Where(u => u.Id == id)
            .ProjectTo<FacultyWithDepartmentDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}