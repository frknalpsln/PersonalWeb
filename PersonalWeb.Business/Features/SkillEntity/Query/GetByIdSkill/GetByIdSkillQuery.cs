using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.SkillEntity.Query.GetByIdSkill
{
    public record GetByIdSkillQuery(
        string Id) : IRequest<Result<GetByIdSkillQueryResponse>>;    
}
