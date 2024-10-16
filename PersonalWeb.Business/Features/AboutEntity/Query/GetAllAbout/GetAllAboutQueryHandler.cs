using MediatR;
using Microsoft.EntityFrameworkCore;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Query.GetAllAbout
{
    internal class GetAllAboutQueryHandler(
       IAboutServices _aboutServices) : IRequestHandler<GetAllAboutQuery, Result<List<About>>>
    {
        public async Task<Result<List<About>>> Handle(GetAllAboutQuery request, CancellationToken cancellationToken)
        {
            List<About> about = await _aboutServices.GetAll().ToListAsync();
            return about;
        }
    }
}
