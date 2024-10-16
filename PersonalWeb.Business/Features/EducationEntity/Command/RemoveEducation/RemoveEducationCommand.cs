using MediatR;
using PersonalWeb.Business.Features.AboutEntity.Command.RemoveAbout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.EducationEntity.Command.RemoveEducation
{
    public record RemoveEducationCommand(
        string Id) : IRequest<Result<string>>;
}
