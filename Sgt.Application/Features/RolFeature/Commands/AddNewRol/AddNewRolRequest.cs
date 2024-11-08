using MediatR;

namespace Sgt.Application.Features.RolFeature.Commands.AddNewRol;

public sealed record AddNewRolRequest(string Name) : IRequest<AddNewRolResponse>;

