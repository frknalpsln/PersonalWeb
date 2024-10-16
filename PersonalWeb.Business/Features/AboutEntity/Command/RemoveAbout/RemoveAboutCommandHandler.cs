using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Command.RemoveAbout
{
    internal class RemoveAboutCommandHandler(
       IAboutServices _aboutServices) : IRequestHandler<RemoveAboutCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(RemoveAboutCommand request, CancellationToken cancellationToken)
        {
            About about = await _aboutServices.GetById(request.Id);

            if (about is null)
            {
                return Result<string>.Failure("About is not found");
            }

            _aboutServices.Remove(about);
            await _aboutServices.SaveAsync();

            return "Hakkımda Silindi";
        }
    }
}
