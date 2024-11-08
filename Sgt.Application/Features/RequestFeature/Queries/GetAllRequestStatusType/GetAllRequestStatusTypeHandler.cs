using MediatR;
using Sgt.Shared.EnumValues;

namespace Sgt.Application.Features.RequestFeature.Queries.GetAllRequestStatusType;

public sealed class GetAllRequestStatusTypeHandler : IRequestHandler<GetAllRequestStatusTypeRequest, List<GetAllRequestStatusTypeResponse>>
{
    public async Task<List<GetAllRequestStatusTypeResponse>> Handle(GetAllRequestStatusTypeRequest request, CancellationToken cancellationToken)
    {
        var result = new List<GetAllRequestStatusTypeResponse>();
        result.Add(new GetAllRequestStatusTypeResponse()
        {
            StatusId = RequestStatusType.Approved.GetHashCode(),
            StatusName = RequestStatusType.Approved.ToString()
        });
        result.Add(new GetAllRequestStatusTypeResponse()
        {
            StatusId = RequestStatusType.Deny.GetHashCode(),
            StatusName = RequestStatusType.Deny.ToString()
        });
        result.Add(new GetAllRequestStatusTypeResponse()
        {
            StatusId = RequestStatusType.Sended.GetHashCode(),
            StatusName = RequestStatusType.Sended.ToString()
        });
        result.Add(new GetAllRequestStatusTypeResponse()
        {
            StatusId = RequestStatusType.Requested.GetHashCode(),
            StatusName = RequestStatusType.Requested.ToString()
        });
        return result;
    }
}
