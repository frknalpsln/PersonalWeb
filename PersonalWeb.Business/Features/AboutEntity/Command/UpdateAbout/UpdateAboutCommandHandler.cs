using AutoMapper;
using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Command.UpdateAbout
{
    internal class UpdateAboutCommandHandler(IAboutServices _aboutServices,
        IMapper _mapper) : IRequestHandler<UpdateAboutCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            About about = await _aboutServices.GetById(request.Id);
            if (about is null)
            {
                return Result<string>.Failure("About Bulunamadı");
            }

            _mapper.Map(request, about);

            _aboutServices.Update(about);
            await _aboutServices.SaveAsync();

            return "About Güncelleme İşlemi Başarılı";
        }
    }
}
