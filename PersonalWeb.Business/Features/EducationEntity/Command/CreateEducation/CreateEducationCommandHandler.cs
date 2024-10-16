using AutoMapper;
using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.EducationEntity.Command.CreateEducation
{
    internal class CreateEducationCommandHandler(IEducationServices _educationServices,
       IMapper _mapper) : IRequestHandler<CreateEducationCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(CreateEducationCommand request, CancellationToken cancellationToken)
        {
            Education education = _mapper.Map<Education>(request);
            await _educationServices.AddAsync(education);
            await _educationServices.SaveAsync();

            return "Ekleme Başarılı";
        }
    }

}
