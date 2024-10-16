using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.EducationEntity.Query.GetByIdEducation
{
    public record GetByIdEducationQuery(
         string Id) : IRequest<Result<GetByIdEducationQueryResponse>>;

}
