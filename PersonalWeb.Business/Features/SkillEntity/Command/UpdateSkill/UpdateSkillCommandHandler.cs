using AutoMapper;
using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.SkillEntity.Command.UpdateSkill
{
    internal class UpdateSkillCommandHandler(
        ISkillServices _skillServices,
        IMapper mapper) : IRequestHandler<UpdateSkillCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
        {
            Skill skill = await _skillServices.GetById(request.Id);
            if (skill is null)
            {
                return Result<string>.Failure("Skill Bulunamadı");
            }
            mapper.Map(request, skill);

            _skillServices.Update(skill);
            await _skillServices.SaveAsync();

            return "Skill Güncelleme İşlemi Başarılı";
        }
    }
}
