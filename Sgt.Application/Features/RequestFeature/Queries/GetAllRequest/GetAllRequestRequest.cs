using MediatR;
using Sgt.Application.Features.RequestFeature.Commands.AddNewRequest;

namespace Sgt.Application.Features.RequestFeature.Queries.GetAllRequest;

public sealed record GetAllRequestRequest() : IRequest<List<GetAllRequestResponse>>;
