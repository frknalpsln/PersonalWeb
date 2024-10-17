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

namespace PersonalWeb.Business.Features.SkillEntity.Command.CreateSkill
{
    internal class CreateSkillCommandHandler(
        ISkillServices _skillServices,
        IMapper mapper) : IRequestHandler<CreateSkillCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(CreateSkillCommand request, CancellationToken cancellationToken)
        {
            Skill skill = mapper.Map<Skill>(request);
            await _skillServices.AddAsync(skill);
            await _skillServices.SaveAsync();

            return "Ekleme Başarılı";
        }
    }
}
