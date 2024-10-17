using MediatR;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.SkillEntity.Query.GetAllSkill
{
    public record GetAllSkillQuery : IRequest<Result<List<Skill>>>;    
}
