using AutoMapper;
using PersonalWeb.Business.Features.AboutEntity.Command.CreateAbout;
using PersonalWeb.Business.Features.AboutEntity.Command.UpdateAbout;
using PersonalWeb.Business.Features.EducationEntity.Command.CreateEducation;
using PersonalWeb.Business.Features.EducationEntity.Command.UpdateEducation;
using PersonalWeb.Business.Features.ExperienceEntity.Command.CreateExperience;
using PersonalWeb.Business.Features.ExperienceEntity.Command.UpdateExperience;
using PersonalWeb.Business.Features.SkillEntity.Command.CreateSkill;
using PersonalWeb.Business.Features.SkillEntity.Command.UpdateSkill;
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
            CreateMap<CreateSkillCommand, Skill>();
            CreateMap<UpdateSkillCommand, Skill>();
            CreateMap<CreateEducationCommand, Education>();
            CreateMap<UpdateEducationCommand, Education>();
            CreateMap<CreateExperienceCommand, Experience>();
            CreateMap<UpdateExperienceCommand, Experience>();

            
        }

    }
}
