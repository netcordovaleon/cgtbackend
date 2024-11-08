
namespace Sgt.Application.Features.RequestFeature.Queries.GetAllRequestStatusType;

public sealed record GetAllRequestStatusTypeResponse {

    public int StatusId { get; set; }
    public string StatusName { get; set; }

}
