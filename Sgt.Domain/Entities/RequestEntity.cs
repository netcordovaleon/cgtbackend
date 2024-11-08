using Sgt.Domain.Common;
using Sgt.Shared.EnumValues;

namespace Sgt.Domain.Entities;

public class RequestEntity : BaseAuditableEntity, IBaseAuditableEntity
{
    public DateTime? RequestStart { get; set; }
    public DateTime? RequestEnd { get; set; }
    public int? HoursRequested { get; set; }
    public string? Description { get; set; }
    public RequestStatusType? RequestStatus { get; set; }
    public string? RequestingUserId { get; set; }
    public string? ReviewerUserId { get; set; }
    public IList<RequestFilesEntity>? files { get; set; } = new List<RequestFilesEntity>();

}
