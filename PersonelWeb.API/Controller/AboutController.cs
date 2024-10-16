using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWeb.Business.Features.AboutEntity.Command.CreateAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.RemoveAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.UpdateAbout;
using PersonalWeb.Business.Features.AboutEntity.Query.GetAllAbout;
using PersonalWeb.Business.Features.AboutEntity.Query.GetByIdAbout;

namespace PersonelWeb.API.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AboutController(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Remove(RemoveAboutCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllAboutQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> GetById(GetByIdAboutQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
