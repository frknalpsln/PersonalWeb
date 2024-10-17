using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.SkillEntity.Command.CreateSkill
{
    public record CreateSkillCommand(
        string Name) : IRequest<Result<string>>;    
}
