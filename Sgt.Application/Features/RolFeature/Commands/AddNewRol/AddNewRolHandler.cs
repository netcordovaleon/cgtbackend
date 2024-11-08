using AutoMapper;
using MediatR;
using Sgt.Application.Repository;
using Sgt.Domain.Entities;

namespace Sgt.Application.Features.RolFeature.Commands.AddNewRol;

public sealed class AddNewRolHandler : IRequestHandler<AddNewRolRequest, AddNewRolResponse>
{
    private readonly IMapper _mapper;
    private readonly IRolRepository _rolRepository;
    public AddNewRolHandler(IRolRepository rolRepository, IMapper mapper)
    {
        _rolRepository = rolRepository;
        _mapper = mapper;
    }

    public async Task<AddNewRolResponse> Handle(AddNewRolRequest request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<RolEntity>(request);
        var entitySaved = await _rolRepository.AddAsync(entity);
        var result = _mapper.Map<AddNewRolResponse>(entitySaved);
        return result;
    }
}
