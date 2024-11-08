using Sgt.Domain.Common;

namespace Sgt.Domain.Entities;

public class UserEntity : BaseAuditableEntity, IBaseAuditableEntity
{
    public string User { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? RolId { get; set; } = string.Empty;
}
