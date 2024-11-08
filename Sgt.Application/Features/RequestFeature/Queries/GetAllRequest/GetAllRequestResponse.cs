using Sgt.Shared.EnumValues;

namespace Sgt.Application.Features.RequestFeature.Queries.GetAllRequest;

public sealed record GetAllRequestResponse
{
    public string Id { get; set; }
    public string? RequestStart { get; set; }
    public string? RequestEnd { get; set; }
    public int? HoursRequested { get; set; }
    public string? Description { get; set; }
    public string? RequestStatus { get; set; }
    public string? RequestingUserId { get; set; }
    public string? ReviewerUserId { get; set; }
}
