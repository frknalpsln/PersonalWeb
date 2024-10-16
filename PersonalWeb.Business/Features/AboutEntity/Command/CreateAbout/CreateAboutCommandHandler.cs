using AutoMapper;
using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Command.CreateAbout
{
    public class CreatAboutCommandHandler
    {
        internal class CreateAboutCommandHandler(IAboutServices _aboutServices,
       IMapper _mapper) : IRequestHandler<CreateAboutCommand, Result<string>>
        {
            public async Task<Result<string>> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
            {
                About sirket = _mapper.Map<About>(request);
                await _aboutServices.AddAsync(sirket);
                await _aboutServices.SaveAsync();

                return "Ekleme Başarılı";
            }
        }
    }
}
