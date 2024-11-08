using AutoMapper;
using MediatR;
using Sgt.Application.Repository;
using Sgt.Domain.Entities;

namespace Sgt.Application.Features.RequestFeature.Commands.AddNewRequest;

public class AddNewRequestHandler : IRequestHandler<AddNewRequestRequest, AddNewRequestResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestRepository _requestRepository;
    public AddNewRequestHandler(IRequestRepository requestRepository, IMapper mapper)
    {
        _requestRepository = requestRepository;
        _mapper = mapper;
    }
    public async Task<AddNewRequestResponse> Handle(AddNewRequestRequest request, CancellationToken cancellationToken)
    {
        if (request.RequestStart <= DateTime.Now) {
            throw new Exception("Start Date should be a valid date, greater than today");
        }

        if (request.RequestStart > request.RequestEnd)
        {
            throw new Exception("End date invalid, should be greater than Start date");
        }

        var entity = _mapper.Map<RequestEntity>(request);
        var entitySaved = await _requestRepository.AddAsync(entity);
        var result = _mapper.Map<AddNewRequestResponse>(entitySaved);
        return result;
    }
}
