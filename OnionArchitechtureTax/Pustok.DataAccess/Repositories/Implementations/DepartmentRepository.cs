using Pustok.Core.Entities;
using Pustok.DataAccess.Contexts;
using Pustok.DataAccess.Repositories.Implementations;

namespace Pustok.DataAccess.Repositories;

public class DepartmentRepository : Repository<Department>, IDepartmentRepository
{
    public DepartmentRepository(PustokDBContext context) : base(context)
    {
    }
}
