using MediatR;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.ExperienceEntity.Query.GetAllExperience
{
    public record GetAllExperienceQuery : IRequest<Result<List<Experience>>>;
   
}
