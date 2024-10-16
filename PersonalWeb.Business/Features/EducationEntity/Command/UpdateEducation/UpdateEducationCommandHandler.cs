using AutoMapper;
using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.EducationEntity.Command.UpdateEducation
{
    internal class UpdateEducationCommandHandler(IEducationServices _educationServices,
        IMapper _mapper) : IRequestHandler<UpdateEducationCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateEducationCommand request, CancellationToken cancellationToken)
        {
            Education education = await _educationServices.GetById(request.Id);
            if (education is null)
            {
                return Result<string>.Failure("Education Bulunamadı");
            }

            _mapper.Map(request, education);

            _educationServices.Update(education);
            await _educationServices.SaveAsync();

            return "Education Güncelleme İşlemi Başarılı";
        }
    }
}
