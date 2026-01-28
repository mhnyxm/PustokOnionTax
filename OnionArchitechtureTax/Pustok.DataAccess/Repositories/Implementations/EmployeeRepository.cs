using Pustok.Core.Entities;
using Pustok.DataAccess.Contexts;
using Pustok.DataAccess.Repositories.Implementations;

namespace Pustok.DataAccess.Repositories;

public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(PustokDBContext context) : base(context)
    {
    }
}
