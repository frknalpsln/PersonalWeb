using AutoMapper;
using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.ExperienceEntity.Command.UpdateExperience
{
    internal class UpdateExperienceCommandHandler(IExperienceServices _experienceServices,
        IMapper _mapper) : IRequestHandler<UpdateExperienceCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateExperienceCommand request, CancellationToken cancellationToken)
        {
            Experience experience = await _experienceServices.GetById(request.Id);
            if (experience is null)
            {
                return Result<string>.Failure("Experience Bulunamadı");
            }
            _mapper.Map(request, experience);

            _experienceServices.Update(experience);
            await _experienceServices.SaveAsync();

            return "Experience Güncelleme İşlemi Başarılı";
        }
    }

}
