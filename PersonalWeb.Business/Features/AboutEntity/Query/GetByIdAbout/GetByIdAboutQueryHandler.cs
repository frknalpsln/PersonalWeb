using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Query.GetByIdAbout
{
    internal class GetByIdAboutQueryHandler(IAboutServices _aboutServices) : IRequestHandler<GetByIdAboutQuery, Result<GetByIdAboutQueryResponse>>
    {
        public async Task<Result<GetByIdAboutQueryResponse>> Handle(GetByIdAboutQuery request, CancellationToken cancellationToken)
        {
            About about = await _aboutServices.GetById(request.Id);

            if (about is null)
            {
                return Result<GetByIdAboutQueryResponse>.Failure("About Bulunamadı");
            }
            return new GetByIdAboutQueryResponse(
                   about.Name,
                   about.Description);           
        }
    }
}
