using Sgt.Domain.Common;

namespace Sgt.Domain.Entities;

public class EmployeeEntity : BaseAuditableEntity, IBaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string DocumentNumber { get; set; } = string.Empty;
    public string UserId { get; set; }
}
