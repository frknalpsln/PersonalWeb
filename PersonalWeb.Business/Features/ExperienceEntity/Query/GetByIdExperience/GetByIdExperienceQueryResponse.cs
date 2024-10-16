using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business.Features.ExperienceEntity.Query.GetByIdExperience
{
    public record GetByIdExperienceQueryResponse(
        string CompanyName,
        string CompanyDescription,
        DateTime StartDate,
        DateTime EndDate);    
}
