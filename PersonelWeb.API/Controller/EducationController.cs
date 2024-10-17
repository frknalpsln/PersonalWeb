using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWeb.Business.Features.AboutEntity.Command.CreateAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.RemoveAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.UpdateAbout;
using PersonalWeb.Business.Features.AboutEntity.Query.GetAllAbout;
using PersonalWeb.Business.Features.AboutEntity.Query.GetByIdAbout;
using PersonalWeb.Business.Features.EducationEntity.Command.CreateEducation;
using PersonalWeb.Business.Features.EducationEntity.Command.RemoveEducation;
using PersonalWeb.Business.Features.EducationEntity.Command.UpdateEducation;
using PersonalWeb.Business.Features.EducationEntity.Query.GetAllEducation;
using PersonalWeb.Business.Features.EducationEntity.Query.GetByIdEducation;

namespace PersonelWeb.API.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EducationControoler(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateEducationCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateEducationCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Remove(RemoveEducationCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllEducationQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> GetById(GetByIdEducationQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
