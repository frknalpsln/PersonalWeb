using PersonalWeb.Business.Abstract;
using PersonalWeb.DataAccess.Abstract;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business.Concrete
{
    public class SkillManager : ISkillServices
    {
        private readonly ISkillRepository _skillRepository;

        public SkillManager(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public async Task<bool> AddAsync(Skill skill)
        {
            return await _skillRepository.AddAsync(skill);
        }

        public IQueryable<Skill> GetAll()
        {
            return _skillRepository.GetAll();
        }

        public async Task<Skill> GetById(string id)
        {
           return await _skillRepository.GetSingleAsync(id);
        }

        public bool Remove(Skill skill)
        {
            return _skillRepository.Remove(skill);  
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return await _skillRepository.RemoveAsync(id);
        }

        public async Task<int> SaveAsync()
        {
            return await _skillRepository.SaveAsync();
        }

        public bool Update(Skill skill)
        {
            return _skillRepository.Update(skill);  
        }
    }
}
