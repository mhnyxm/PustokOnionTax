using Pustok.Core.Entities.Common;

namespace Pustok.Core.Entities;

public class Department:BaseAuditableEntity
{
    public string Name { get; set; }        
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }

    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
