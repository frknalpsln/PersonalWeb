using MediatR;
using Microsoft.EntityFrameworkCore;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Business.Features.ExperienceEntity.Query.GetAllExperience;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.SkillEntity.Query.GetAllSkill
{
    internal class GetAllSkillQueryHandler(
         ISkillServices _skillServices) : IRequestHandler<GetAllSkillQuery, Result<List<Skill>>>
    {
        public async Task<Result<List<Skill>>> Handle(GetAllSkillQuery request, CancellationToken cancellationToken)
        {
            List<Skill> skill = await _skillServices.GetAll().ToListAsync();
            return skill;
        }
    }
    
}
