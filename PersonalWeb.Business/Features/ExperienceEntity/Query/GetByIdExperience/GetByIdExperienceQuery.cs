using MediatR;
using PersonalWeb.Business.Features.EducationEntity.Query.GetByIdEducation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.ExperienceEntity.Query.GetByIdExperience
{
    public record GetByIdExperienceQuery(
         string Id) : IRequest<Result<GetByIdExperienceQueryResponse>>;
    
}
