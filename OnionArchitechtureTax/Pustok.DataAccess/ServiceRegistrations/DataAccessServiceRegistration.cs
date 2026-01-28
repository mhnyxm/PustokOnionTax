using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pustok.DataAccess.Contexts;
using Pustok.DataAccess.Repositories;
using Pustok.DataAccess.Repositories.Implementations;

namespace Pustok.DataAccess.ServiceRegistrations;

public static class DataAccessServiceRegistration
{
    public static void AddDataAccessServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<PustokDBContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("Default"));
        });
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    }
}
