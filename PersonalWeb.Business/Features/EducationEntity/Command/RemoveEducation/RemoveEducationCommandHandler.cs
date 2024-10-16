using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.EducationEntity.Command.RemoveEducation
{
    internal class RemoveEducationCommandHandler(
       IEducationServices _educationServices) : IRequestHandler<RemoveEducationCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(RemoveEducationCommand request, CancellationToken cancellationToken)
        {
            Education education = await _educationServices.GetById(request.Id);

            if (education is null)
            {
                return Result<string>.Failure("Education is not found");
            }

            _educationServices.Remove(education);
            await _educationServices.SaveAsync();

            return "Education Silindi";
        }
    }
}
