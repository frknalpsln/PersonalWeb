using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.ExperienceEntity.Command.UpdateExperience
{
    public record UpdateExperienceCommand(
        string Id,
        string CompanyName,
        string CompanyDescription,
        DateTime StartDate,
        DateTime EndDate) : IRequest<Result<string>>;
}
