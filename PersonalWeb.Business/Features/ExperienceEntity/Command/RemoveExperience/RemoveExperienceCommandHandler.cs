using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.ExperienceEntity.Command.RemoveExperience
{
    internal class RemoveExperienceCommandHandler(
       IExperienceServices _experienceServices) : IRequestHandler<RemoveExperienceCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(RemoveExperienceCommand request, CancellationToken cancellationToken)
        {
            Experience experience = await _experienceServices.GetById(request.Id);

            if (experience is null)
            {
                return Result<string>.Failure("Experience is not found");
            }

            _experienceServices.Remove(experience);
            await _experienceServices.SaveAsync();

            return "Experience Silindi";
        }
    }
}
