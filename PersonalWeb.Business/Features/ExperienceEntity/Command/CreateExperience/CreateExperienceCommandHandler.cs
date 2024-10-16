using AutoMapper;
using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.ExperienceEntity.Command.CreateExperience
{
    internal class CreateExperienceCommandHandler(IExperienceServices _experienceServices,
       IMapper _mapper) : IRequestHandler<CreateExperienceCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(CreateExperienceCommand request, CancellationToken cancellationToken)
        {
            Experience experience = _mapper.Map<Experience>(request);
            await _experienceServices.AddAsync(experience);
            await _experienceServices.SaveAsync();

            return "Ekleme Başarılı";
        }
    }
}
