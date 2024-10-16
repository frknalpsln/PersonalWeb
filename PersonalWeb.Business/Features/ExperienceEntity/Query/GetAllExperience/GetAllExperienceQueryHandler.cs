using MediatR;
using Microsoft.EntityFrameworkCore;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Business.Features.EducationEntity.Query.GetAllEducation;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.ExperienceEntity.Query.GetAllExperience
{
    internal class GetAllExperienceQueryHandler(
        IExperienceServices _experienceServices) : IRequestHandler<GetAllExperienceQuery, Result<List<Experience>>>
    {
        public async Task<Result<List<Experience>>> Handle(GetAllExperienceQuery request, CancellationToken cancellationToken)
        {
            List<Experience> experience = await _experienceServices.GetAll().ToListAsync();
            return experience;

        }
    }
}

