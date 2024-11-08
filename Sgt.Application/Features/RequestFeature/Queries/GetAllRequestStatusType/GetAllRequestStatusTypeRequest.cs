using MediatR;

namespace Sgt.Application.Features.RequestFeature.Queries.GetAllRequestStatusType;

public sealed record GetAllRequestStatusTypeRequest() : IRequest<List<GetAllRequestStatusTypeResponse>>;