using Pustok.Core.Entities.Common;

namespace Pustok.Core.Entities;

public class Employee: BaseAuditableEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public decimal Salary { get; set; }
    public bool IsActive { get; set; }

    public int DepartmentId { get; set; }

    public Department Department { get; set; }
}
