using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWeb.Business.Features.AboutEntity.Command.CreateAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.RemoveAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.UpdateAbout;
using PersonalWeb.Business.Features.AboutEntity.Query.GetAllAbout;
using PersonalWeb.Business.Features.AboutEntity.Query.GetByIdAbout;
using PersonalWeb.Business.Features.SkillEntity.Command.CreateSkill;
using PersonalWeb.Business.Features.SkillEntity.Command.RemoveSkill;
using PersonalWeb.Business.Features.SkillEntity.Command.UpdateSkill;
using PersonalWeb.Business.Features.SkillEntity.Query.GetAllSkill;
using PersonalWeb.Business.Features.SkillEntity.Query.GetByIdSkill;

namespace PersonelWeb.API.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SkillController(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateSkillCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateSkillCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> Remove(RemoveSkillCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllSkillQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<IActionResult> GetById(GetByIdSkillQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
