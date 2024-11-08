using Sgt.Domain.Common;

namespace Sgt.Domain.Entities;

public class RolEntity : BaseNonAuditableEntity, IBaseNonAuditableEntity
{
    public string Name { get; set; } = string.Empty;

}
