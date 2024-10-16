using MediatR;
using PersonalWeb.Business.Features.AboutEntity.Query.GetAllAbout;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.EducationEntity.Query.GetAllEducation
{
    public record GetAllEducationQuery : IRequest<Result<List<Education>>>;
}
