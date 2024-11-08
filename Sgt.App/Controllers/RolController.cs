using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sgt.Application.Features.RolFeature.Commands.AddNewRol;

namespace Sgt.App.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RolController : ControllerBase
{
    private readonly IMediator _mediator;
    public RolController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("")]
    public async Task<AddNewRolResponse> Save(AddNewRolRequest command) {
        var response = await _mediator.Send(command);
        return response;
    }

}
