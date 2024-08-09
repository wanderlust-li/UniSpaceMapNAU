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
        return await _unitOfWork.FaluctyRepository.List()
            .AsNoTracking()
            .Include(s => s.Departments)
            .ProjectTo<FacultyDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}