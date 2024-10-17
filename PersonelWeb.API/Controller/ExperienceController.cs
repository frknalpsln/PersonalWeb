using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWeb.Business.Features.AboutEntity.Command.CreateAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.RemoveAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.UpdateAbout;
using PersonalWeb.Business.Features.AboutEntity.Query.GetAllAbout;
using PersonalWeb.Business.Features.AboutEntity.Query.GetByIdAbout;
using PersonalWeb.Business.Features.EducationEntity.Query.GetByIdEducation;
using PersonalWeb.Business.Features.ExperienceEntity.Command.CreateExperience;
using PersonalWeb.Business.Features.ExperienceEntity.Command.RemoveExperience;
using PersonalWeb.Business.Features.ExperienceEntity.Command.UpdateExperience;
using PersonalWeb.Business.Features.ExperienceEntity.Query.GetAllExperience;
using PersonalWeb.Business.Features.ExperienceEntity.Query.GetByIdExperience;

namespace PersonelWeb.API.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExperienceController(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateExperienceCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateExperienceCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Remove(RemoveExperienceCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllExperienceQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> GetById(GetByIdExperienceQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
