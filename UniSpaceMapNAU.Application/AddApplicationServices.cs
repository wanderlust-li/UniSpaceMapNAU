using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using UniSpaceMapNAU.Application.Interfaces.IServices;
using UniSpaceMapNAU.Application.Services;

namespace UniSpaceMapNAU.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this  IServiceCollection services)
    {
        services.AddScoped<IFacultyService, FacultyService>();
        services.AddScoped<IRoomTypeService, RoomTypeService>();
        services.AddScoped<IBuildingService, BuildingService>();
        services.AddScoped<IDepartmentService, DepartmentService>();
        services.AddScoped<IRoomService, RoomService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}