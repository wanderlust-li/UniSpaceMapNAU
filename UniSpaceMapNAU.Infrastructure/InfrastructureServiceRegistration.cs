using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UniSpaceMapNAU.Application.Interfaces;
using UniSpaceMapNAU.Infrastructure.Data;
using UniSpaceMapNAU.Infrastructure.Repository;

namespace UniSpaceMapNAU.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        
        return services;
    }
}