using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using Pustok.DataAccess.Contexts;
using Pustok.DataAccess.Repositories.Abstractions;
using Pustok.DataAccess.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
