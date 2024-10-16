using MediatR;
using Microsoft.EntityFrameworkCore;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.EducationEntity.Query.GetAllEducation
{
    internal class GetAllEducationQueryHandler(
       IEducationServices _educationServices) : IRequestHandler<GetAllEducationQuery, Result<List<Education>>>
    {
        public async Task<Result<List<Education>>> Handle(GetAllEducationQuery request, CancellationToken cancellationToken)
        {
            List<Education> education = await _educationServices.GetAll().ToListAsync();
            return education;
        }
    }
}
