using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.SkillEntity.Command.UpdateSkill
{
    public record UpdateSkillCommand(
        string Id,
        string Name) : IRequest<Result<string>>;   
}
