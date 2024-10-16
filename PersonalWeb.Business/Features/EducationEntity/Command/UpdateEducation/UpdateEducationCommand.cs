using MediatR;
using PersonalWeb.Business.Features.AboutEntity.Command.UpdateAbout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.EducationEntity.Command.UpdateEducation
{
    public record UpdateEducationCommand(
         string Id,
         string Name,
         string Department,
         DateTime StartDate,
         DateTime EndDate) : IRequest<Result<string>>;
}
