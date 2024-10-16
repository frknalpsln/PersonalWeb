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
    public class ExperienceManager : IExperienceServices
    {
        private readonly IExperienceRepository _experienceRepository;

        public ExperienceManager(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public async Task<bool> AddAsync(Experience experience)
        {
           return await _experienceRepository.AddAsync(experience);
        }

        public IQueryable<Experience> GetAll()
        {
           return _experienceRepository.GetAll();
        }

        public Task<Experience> GetById(string id)
        {
            return _experienceRepository.GetSingleAsync(id);
        }

        public bool Remove(Experience experience)
        {
            return _experienceRepository.Remove(experience);
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return await _experienceRepository.RemoveAsync(id);
        }

        public async Task<int> SaveAsync()
        {
            return await _experienceRepository.SaveAsync();
        }

        public bool Update(Experience experience)
        {
            return _experienceRepository.Update(experience);
        }
    }
}
