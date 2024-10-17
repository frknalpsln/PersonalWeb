using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.SkillEntity.Command.RemoveSkill
{
    internal class RemoveSkillCommandHandler(
        ISkillServices _skillServices) : IRequestHandler<RemoveSkillCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(RemoveSkillCommand request, CancellationToken cancellationToken)
        {
            Skill skill = await _skillServices.GetById(request.Id);

            if (skill is null)
            {
                return Result<string>.Failure("Skill is not found");
            }

            _skillServices.Remove(skill);
            await _skillServices.SaveAsync();

            return "Skill Silindi";
        }
    }
}
