using Sgt.Domain.Common;

namespace Sgt.Domain.Entities;

public class RequestFilesEntity : BaseNonAuditableEntity, IBaseNonAuditableEntity
{
    public string FileUrl { get; set; }
}
