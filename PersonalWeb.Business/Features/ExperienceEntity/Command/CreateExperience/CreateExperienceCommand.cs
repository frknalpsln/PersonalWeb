using MediatR;
using PersonalWeb.Business.Features.EducationEntity.Command.CreateEducation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.ExperienceEntity.Command.CreateExperience
{
    public record CreateExperienceCommand(
        string CompanyName,
        string CompanyDescription,
        DateTime StartDate,
        DateTime EndDate) : IRequest<Result<string>>;
}
