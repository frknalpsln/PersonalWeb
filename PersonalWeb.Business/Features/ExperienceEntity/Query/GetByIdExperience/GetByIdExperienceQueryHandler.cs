using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Business.Features.EducationEntity.Query.GetByIdEducation;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.ExperienceEntity.Query.GetByIdExperience
{
    internal class GetByIdExperienceQueryHandler(IExperienceServices _experienceServices) : IRequestHandler<GetByIdExperienceQuery, Result<GetByIdExperienceQueryResponse>>
    {
        public async Task<Result<GetByIdExperienceQueryResponse>> Handle(GetByIdExperienceQuery request, CancellationToken cancellationToken)
        {
            Experience experience = await _experienceServices.GetById(request.Id);

            if (experience is null)
            {
                return Result<GetByIdExperienceQueryResponse>.Failure("Experience Bulunamadı");
            }
            return new GetByIdExperienceQueryResponse(
                   experience.CompanyName,
                   experience.CompanyDescription,
                   experience.StartDate,
                   experience.EndDate);
        }
    }

}
