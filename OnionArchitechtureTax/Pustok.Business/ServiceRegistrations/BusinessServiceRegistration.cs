using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pustok.Business.Services;
using System.Reflection;

namespace Pustok.Business.ServiceRegistrations;

public static class BusinessServiceRegistration
{
    public static void AddBusinessServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IDepartmentService, DepartmentService>();
    }
}
