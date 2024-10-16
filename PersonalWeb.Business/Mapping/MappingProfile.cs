using AutoMapper;
using PersonalWeb.Business.Features.AboutEntity.Command.CreateAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.UpdateAbout;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateAboutCommand, About>();
            CreateMap<UpdateAboutCommand, About>();
        }
    }
}
