namespace Pustok.Core.Entities.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
}

public abstract class BaseAuditableEntity : BaseEntity
{
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = string.Empty;
    public DateTime? UpdatedDate { get; set; }

    public string DeletedBy { get; set; } = string.Empty;
    public DateTime? DeletedDate { get; set; }
    public bool IsDeleted { get; set; } = false;

}