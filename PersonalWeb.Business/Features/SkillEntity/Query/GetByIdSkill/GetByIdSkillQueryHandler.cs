using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Business.Features.ExperienceEntity.Query.GetByIdExperience;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.SkillEntity.Query.GetByIdSkill
{
    internal class GetByIdSkillQueryHandler(ISkillServices _skillServices) : IRequestHandler<GetByIdSkillQuery, Result<GetByIdSkillQueryResponse>>
    {
        public async Task<Result<GetByIdSkillQueryResponse>> Handle(GetByIdSkillQuery request, CancellationToken cancellationToken)
        {
            Skill skill = await _skillServices.GetById(request.Id);

            if (skill is null)
            {
                return Result<GetByIdSkillQueryResponse>.Failure("Skill Bulunamadı");
            }
            return new GetByIdSkillQueryResponse(
                   skill.Name);
        }
    }
    
}
